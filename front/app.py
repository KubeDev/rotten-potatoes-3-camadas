from re import A
from flask import Flask, render_template, request, url_for, redirect, Response, jsonify
import os 
from models.review import Review
from models.filme import Filme
import bson
from prometheus_flask_exporter import PrometheusMetrics
from middleware import set_unhealth, set_unready_for_seconds, middleware
from datetime import datetime

from services.filme import FilmeService

app = Flask(__name__,
            static_url_path='', 
            static_folder='static',
            template_folder='templates')

app.wsgi_app = middleware(app.wsgi_app)

metrics = PrometheusMetrics(app, default_labels={'version': '1.0'})

filme_service = FilmeService()

@app.route('/')
def index():

    filmes = filme_service.list_filmes()
    app.logger.info('Obtendo a lista de filmes no MongoDB')      
    sliders = sorted(filmes, key=lambda x: len(x.reviews), reverse=False)
    sliders = sliders[-3:]
    return render_template('index.html', filmes=filmes, sliders=sliders)

@app.route('/single/<string:oid>', methods=['GET','POST'])
def single(oid):

    filme = filme_service.get_filme(oid)

    if request.method == 'GET':  
        app.logger.info('Entrando na pagina de review do filme %s', filme.titulo)      
        return render_template('single.html', filme = filme)
    else:
        app.logger.info('Efetuando cadastro de review no filme %s', filme.titulo)
        nome = request.form['nome']
        review = request.form['review']  
        o_review = Review(nome=nome, review=review)        
        filme_service.post_review(oid, o_review)
        return redirect(url_for('single', oid=oid))

@app.route('/host')
def host():
    return jsonify({"host": os.uname().nodename}) 

if __name__ == '__main__':
    app.run()
