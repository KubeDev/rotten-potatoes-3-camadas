class Filme:
    def __init__(self,filme_id, titulo, resumo, duracao, lancamento, categoria, elenco, direcao, reviews=[], slide=None, thumb=None):
        self.filme_id = filme_id
        self.titulo = titulo
        self.resumo = resumo
        self.duracao = duracao
        self.lancamento = lancamento
        self.categoria = categoria
        self.elenco = elenco
        self.direcao = direcao
        self.reviews = reviews
        self.slide = slide
        self.thumb = thumb

    def add_review(self, review):
        self.reviews.append(review)
