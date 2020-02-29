#include<stdio.h>
#include<stdlib.h>

typedef struct arv{
	char info;
	struct arv* esq;
	struct arv* dir;
}Arv;

Arv* inicializa()
{
	return NULL;
}

Arv* cria(char c, Arv* sae, Arv* sad){
	Arv *novo = (Arv*)malloc(sizeof(Arv));
	novo->info = c;
	novo->esq = sae;
	novo->dir = sad;
	return novo;
}

int vazia(Arv*a){
	return a == NULL;
}

void imprimePre(Arv*a){
	if (!vazia(a)){
		printf("%c ", a->info);
		imprimePre(a->esq);
		imprimePre(a->dir);
	}
}

void imprimeOr(Arv*a){
	if (!vazia(a)){
		imprimeOr(a->esq);
		printf("%c ", a->info);
		imprimeOr(a->dir);
	}
}
void imprimePo(Arv*a){
	if (!vazia(a)){
		imprimePo(a->esq);
		imprimePo(a->dir);
		printf("%c ", a->info);
	}
}
int busca(Arv* a, char c){
	if (vazia(a))
		return 0; /* árvore vazia: não encontrou */
	else
		return a->info == c || busca(a->esq, c) || busca(a->dir, c);
}

void main(){
	Arv *a2 = cria('h', inicializa(), inicializa());
	Arv *a6 = cria('o', inicializa(), inicializa());
	Arv *a7 = cria('t', inicializa(), inicializa());
	Arv *a1 = cria('d', inicializa(), inicializa());
	Arv *a5 = cria('p', a6, a7);
	Arv *a3 = cria('g', a1, inicializa());
	Arv *a4 = cria('m', a3, a5);
	a1->dir = a2;
	imprimeOr(a4);
	if (busca(a4, 'z'))
		printf("\nz encontrado\n");
	else
		printf("\nz nao encontrado\n");
	if (busca(a4, 'd'))
		printf("\nd encontrado\n");
	else
		printf("\nd nao encontrado\n");

}