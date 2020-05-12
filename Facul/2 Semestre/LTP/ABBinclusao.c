#include<stdio.h>
#include<stdlib.h>

typedef struct arv{
	int info;
	struct arv * esq;
	struct arv * dir;
}Arv;

Arv* inicia(){
	return NULL;
}

Arv *insere(Arv* a, int v){
	if (a==NULL){
		a=(Arv *)malloc(sizeof(Arv));
		a->info=v;
		a->esq=NULL;
		a->dir=NULL;
	}
	else
	{
		if (v<a->info)
			a->esq=insere(a->esq,v);
		else
			a->dir=insere(a->dir,v);
    }
	return a;
}
Arv* busca(Arv* r, char v)
{
	if (r == NULL) 
		return NULL;
	else
		if (r->info > v)
			return busca(r->esq, v);
		else
			if (r->info < v)
				return busca(r->dir, v);
			else
				return r;
}
int vazia(Arv* a){
	return a == NULL;
}
void imprime(Arv* a){
	if (!vazia(a)){
		imprime(a->esq); /* mostra sae */
		printf("%d ", a->info); /* mostra raiz */
		imprime(a->dir); /* mostra sad */
	}
}
void main(){
   Arv *abb=inicia();
   abb=insere(abb,100);
   abb=insere(abb,50);
   abb=insere(abb,80);
   abb=insere(abb,200);
   abb=insere(abb,20);
   abb=insere(abb,70);
   abb=insere(abb,25);
   abb=insere(abb,120);
   abb=insere(abb,140);
   abb=insere(abb,135);
   abb=insere(abb,88);
   abb=insere(abb,140);
   abb=insere(abb,14);
   abb=insere(abb,13);
   abb=insere(abb,29);
   abb=insere(abb,44);
   imprime(abb);
}
