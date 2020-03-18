#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <locale.h>
#include <time.h>
#include<conio.h>

char entrasn(){
	char sn;
	scanf("%c",&sn);
	fflush(stdin);
	if(sn=='s')
		sn='S';
	if(sn=='n')
		sn='N';
	if(sn != 'S'&&sn != 'N')
		do{
			printf("Resposta inválida, insira novamente (S/N) \n");
			scanf("%c",&sn);
			fflush(stdin);	
		}while((sn!='S'&&sn !='N'));
	return sn;
}

int entrai(){
	int numero;
	int x=1;
	do{
		x=scanf("%d", &numero);
		getchar();
		if(x==0)
			printf("Informação Inválida\n");
	}while(x==0);
	return numero;
}

typedef struct Ficha{
	char nome[200];
	int idade;
	char email[200];
	char deficiencia;
}Ficha;

int main(void) {
	int contagem, contconv, contdef;
	Ficha convidado [20];
	Ficha pessoa[80];
	char resp, resp1 = '1',c;
	int cadeira,j,i;

	for (i = 0; i < 21 ; i++){
		convidado[i].idade=0;
	}
	for (i = 0; i < 101 ; i++){
		pessoa[i].idade=0;
	}

	setlocale (LC_ALL,"portuguese");

	contagem = 26;
	contconv = 1;
	contdef = 21;

	do {
		printf("***PRESSIONE A TECLA ENTER PARA COMEÇAR***\n");
		scanf("%c", &resp1);
		fflush(stdin);
		system("cls");
		printf("Selecione a opção desejada:\n\n");
		printf("1 - Comprar ingresso\n");
		printf("2 - Sorteio\n");
		printf("3 - Informações sobre a cadeira \n");
		printf("4 - Sair\n\n");
		scanf("%c", &resp1);
		fflush(stdin);
		system("cls");
		switch(resp1){
		case '1':
			printf("\n***BEM VINDO AO INGRESSO.COM***\n");


			if((contdef==25) && (contconv==20) && (contagem ==100)){
				printf("\n\n CADEIRAS ESGOTADAS \n\n");
			}else{
				printf("\nÉ convidado do palestrante? (S/N) \n");
				resp=entrasn();
				switch(resp){
				case 'S':
				if(contconv > 20){
						printf("NÃO HÁ LUGARES DISPONÍVEIS PARA CONVIDADOS");
					}else{
						printf("\nDigite seu nome\n");
						gets(convidado[contconv].nome);
						printf("\nDigite sua idade\n");
						convidado[contconv].idade = entrai();
						printf("\nDigite seu email\n");
						gets(convidado[contconv].email);
						system("cls");

						printf("\nParabéns pela compra de seu ingresso!\nGuarde o número de sua cadeira!\n");
						printf("\nNome: %s", convidado[contconv].nome);
						printf("\nIdade: %d", convidado[contconv].idade);
						printf("\nE-mail: %s", convidado[contconv].email);
						printf("\nCadeira: %d \n", contconv);
						printf("\nData da Palestra: 19/12/2018 (Quarta-feira)");
						printf("\nHorário: 18:00 Hrs\n\n");
						contconv++;
						system("pause");
						system("cls");
					}
					break;
					return(0);
				case 'N':	

					printf("\nPossui necessidade especial?\n");
					pessoa[contdef].deficiencia=entrasn();

					switch(pessoa[contdef].deficiencia){
					case 'S':
						if(contdef > 25){
							printf("NÃO HÁ MAIS LUGARES DISPONÍVEIS PARA DEFICIENTES \n ");
						}else{
							printf("\nDigite seu nome\n");
							gets(pessoa[contdef].nome);
							printf("\nDigite sua idade\n");
							pessoa[contdef].idade=entrai();
							printf("\nDigite seu email\n");
							gets(pessoa[contdef].email);
							system("cls");

							printf("\nParabéns pela compra de seu ingresso!\nGuarde o número de sua cadeira!\n");
							printf("\nNome: %s", pessoa[contdef].nome);
							printf("\nNecessidade Especial: %c", pessoa[contdef].deficiencia);
							printf("\nIdade: %d", pessoa[contdef].idade);
							printf("\nE-mail: %s", pessoa[contdef].email);
							printf("\nCadeira: %d \n", contdef);
							printf("\nData da Palestra: 19/12/2018 (Quarta-feira)");
							printf("\nHorário: 18:00 Hrs\n\n");
							contdef++;
							system("pause");
							system("cls");
						}
						break;
						return(0);
					case 'N':
						if(contagem > 100){
							printf("NÃO HÁ LUGARES DISPONÍVEIS PARA NÃO CONVIDADOS OU NÃO DEFICIENTES");
						}else{
							pessoa[contagem].deficiencia = 'N';
							printf("\nDigite seu nome\n");
							gets(pessoa[contagem].nome);
							printf("\nDigite sua idade\n");
							pessoa[contagem].idade=entrai();
							printf("\nDigite seu email\n");
							gets(pessoa[contagem].email);
							system("cls");

							printf("\nParabéns pela compra de seu ingresso!\nGuarde o número de sua cadeira!\n");
							printf("\nNome: %s", pessoa[contagem].nome);
							printf("\nNecessidade Especial: %c", pessoa[contagem].deficiencia);
							printf("\nIdade: %d", pessoa[contagem].idade);
							printf("\nE-mail: %s", pessoa[contagem].email);
							printf("\nCadeira: %d \n", contagem);
							printf("\nData da Palestra: 19/12/2018 (Quarta-feira)");
							printf("\nHorário: 18:00 Hrs\n\n");
							contagem++;
							system("pause");
							system("cls");
						}
						break;
						return(0);
					}

				}
				break;
			}
		case '2':
			printf("\nO número sorteado é: %d\n\n", rand() %80 +21);
			system("pause");
			system("cls");
			break;
		case '3':
			printf("DIGITE O NÚMERO DA CADEIRA\n\n");
			cadeira = entrai();
			if( (cadeira>=1) && (cadeira <=20)){
				if (convidado[cadeira].idade==0 ){
					printf("CADEIRA VAZIA\n\n");
				}else{
					printf("\nNome: %s", convidado[cadeira].nome);
					printf("\nIdade: %d", convidado[cadeira].idade);
					printf("\nE-mail: %s", convidado[cadeira].email);
					printf("\nCadeira: %d \n", cadeira);
					printf("\nData da Palestra: 19/12/2018 (Quarta-feira)");
					printf("\nHorário: 18:00 Hrs\n\n");
				}
			}
			if( (cadeira > 20) && (cadeira <=100)){
				if (pessoa[cadeira].idade==0){
					printf("CADEIRA VAZIA\n\n");
				}else{
					printf("\nNome: %s", pessoa[cadeira].nome);
					printf("\nNecessidade Especial: %c", pessoa[cadeira].deficiencia);
					printf("\nIdade: %d", pessoa[cadeira].idade);
					printf("\nE-mail: %s", pessoa[cadeira].email);
					printf("\nCadeira: %d \n", cadeira);
					printf("\nData da Palestra: 19/12/2018 (Quarta-feira)");
					printf("\nHorário: 18:00 Hrs\n\n");
				}
			}
			if(cadeira > 100){
				printf("Máximo de cadeiras = 100 \nTente novamente\n");
			}
			system("pause");
			system("cls");
			break;
		case '4':
			exit(1);
			break;
			system("pause");
			system("cls");
			return(0);

		default:
			printf("\nOpção inválida, insira novamente!\n");

			system("pause");
			system("cls");

		}
	}while(resp1 != '4');
}