# -*- coding: utf-8 -*-
from functools import reduce
#reduce recebe uma lista e devolve um unico valor

def soma(x,y):
    return x+y

lista = [1,3,5,10,20]

soma = reduce(soma,lista)
        #recebe função, depois valores
print(soma)