#include <stdio.h>
#include <string.h>
#include <stdlib.h>
typedef struct Ficha{
	char nome[200];
	int sorteio, idade;
	char email[200];
}Ficha;
int main(void) {
	int contagem, contconv, contdef;
	Ficha convidado [20];
	Ficha deficiente[5];
	Ficha pessoa[75];
	char resp;

	contagem = 1;
	contconv = 1;
	contdef = 1;

	do {
		printf("\n***BEM VINDO AO INGRESSO.COM***\n");
		printf("\n� convidado do palestrante? (S/N) \n");
		scanf("%c", &resp);
		fflush(stdin);
		do {
			switch(resp){
			case 'S':
				printf("\nDigite seu nome\n");
				gets(convidado[contconv].nome);
				printf("\nDigite sua idade\n");
				do {
					scanf_s("%d", &convidado[contconv].idade);
					fflush(stdin);
				} while (!(convidado[contconv].idade > 0));
				printf("\nDigite seu email");
				gets(convidado[contconv].email);

				printf("\nParab�ns pela compra de seu ingresso!\nGuarde o n�mero de sua cadeira!\n");
				printf("\nNome: %c", convidado[contconv].nome);
				printf("\nIdade: %d", convidado[contconv].idade);
				printf("\nE-mail: %c", convidado[contconv].email);
				printf("\nCadeira: %d \n", contconv);
				contconv = contconv + 1;
				break;
			case 'N':
				printf("\nDigite seu nome\n");
				gets(pessoa[contagem].nome);
				printf("\nPossui deficiencia?");

				printf("\nDigite sua idade\n");
				do {
					scanf_s("%d", &pessoa[contconv].idade);
					fflush(stdin);
				} while (!(pessoa[contagem].idade>0));
				printf("\nDigite seu email\n");
				gets(pessoa[contconv].email);

				printf("\nParab�ns pela compra de seu ingresso!\nGuarde o n�mero de sua cadeira!\n");
				printf("\nNome: %c", pessoa[contagem].nome);
				printf("\nIdade: %d", pessoa[contagem].idade);
				printf("\nE-mail: %c", pessoa[contagem].email);
				printf("\nCadeira: %d \n", contagem);
				contagem = contagem + 1;
				break;
			}while (!(contagem + contconv + contdef == 100));


		}while(!(resp == 'S' || resp == 'N'));


	}while(!(contagem + contconv == 100));
}
