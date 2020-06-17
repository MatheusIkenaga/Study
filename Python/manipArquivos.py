# -*- coding: utf-8 -*-

'''
funcao open

variavel = open(nome, modo)

modos
 
 r   |  somente leitura
 w   |  escrita (caso exista, será sobreposto)
 a   |  Leitura e escrita (Add novo conteúdo ao fim do arquivo) 
 r+  |  Leitura e escrita
 w+  |  escrita ( sobrepoe o arquivo)
 a+  |  eitura e escrita ( abre o arquivo para att)

arquivo = open("/Users/matheusikenaga/GitHub/Study/Python/arquivo.txt")

linhas = arquivo.readlines() #cria um array com as linhas
print(linhas)

print(arquivo.read()) #le o arquivo todo
'''

w = open("/Users/matheusikenaga/GitHub/Study/Python/arquivo2.txt", "a") #cria um arquivo
w.write("This is my file\n") #escreve no arquivo
w.close() #fecha 
