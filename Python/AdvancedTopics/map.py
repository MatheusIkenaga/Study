# -*- coding: utf-8 -*-


def dobro(x):
    return x*2


valor = 2
lista= [1,2,3,4,5]
'''
print(dobro(valor)) #assim retorna o dobro
print(dobro(lista)) #duplica a lista e concatena
'''

valordobrado = map(dobro, lista) 
            #recebe primeiro a função, depois os valores

valordobrado = list(valordobrado)
print(valordobrado)