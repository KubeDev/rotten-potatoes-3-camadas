import requests
import os
from typing import List
from datetime import datetime

from models.filme import Filme
from models.review import Review


class FilmeService:
    def __init__(self):
        self.base_url: str = os.getenv("API_URL", "http://localhost:8080/api")

    def list_filmes(self) -> List[Filme]:
        response = requests.get(self.base_url + '/filme')
        filmes_data = response.json()
        filmes = []
        for filme_data in filmes_data:
            filme = Filme(
                filme_id=filme_data['filmeId'],
                titulo=filme_data['titulo'],
                resumo=filme_data['resumo'],
                duracao=filme_data['duracao'],
                lancamento=filme_data['lancamento'],
                categoria=filme_data['categoria'],
                elenco=filme_data['elenco'],
                direcao=filme_data['direcao'],
                reviews=[Review(**review_data) for review_data in filme_data['reviews']],
                slide=filme_data['slide'],
                thumb=filme_data['thumb']
            )
            filmes.append(filme)
        return filmes

    def get_filme(self, oid: str) -> Filme:
        response = requests.get(self.base_url + '/filme/' + oid)
        filme_data = response.json()
        filme = Filme(
            filme_id=filme_data['filmeId'],
            titulo=filme_data['titulo'],
            resumo=filme_data['resumo'],
            duracao=filme_data['duracao'],
            lancamento=filme_data['lancamento'],
            categoria=filme_data['categoria'],
            elenco=filme_data['elenco'],
            direcao=filme_data['direcao'],
            reviews=[Review(nome=review_data["nome"], review=review_data["descricao"]) for review_data in filme_data['reviews']],
            slide=filme_data['slide'],
            thumb=filme_data['thumb']
        )
        return filme

    def post_review(self, oid: str, review: Review):
        review_data = {
            "nome": review.nome,
            "descricao": review.review,
            "filmeId": 0
        }
        response = requests.post(self.base_url + '/filme/' + oid + "/review", json=review_data)
        teste = ""
