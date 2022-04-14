import re

polski = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
ikslop = polski[::-1]

def szyfr(s):
    try:
        mapa = dict(zip(polski, ikslop))
        chars = (mapa[char] for char in s)
        return ''.join(chars)
    except:
        return

lista = {}
with open('ang.txt', encoding='utf8') as f:
    for line in f:
        lines = line.split()
        for word in lines:
            if len(word) == 4:
                word = word.upper()
                cip = szyfr(str(word))
                cip = str(cip)
                #print(word)
                #print(word + " = " + cip)
                lista[word] = cip

#print(lista)
for key, value in lista.items():
    if value in lista:
        print(key, " -> ", value)
