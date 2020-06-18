#-*- coding: utf-8 -*-
'''
Exemplo, escrever o indice e o contetúdo dessa lista
'''
lista = ["abacate", "bola", "cachorro"]

#Sem enumerate
for i in range(len(lista)):
    print(i, lista[i])

#Com enumerate
print("\nCom enumerate")
for i, nome in enumerate(lista):
    #I é o indice
    #Nome é o conteúdo
    #A enumertate pega isso da lista
    print(i,nome)