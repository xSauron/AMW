import re

polski = "AĄBCĆDEĘFGHIJKLŁMNŃOÓPRSŚTUWYZŹŻ"
ikslop = polski[::-1]

def szyfr(s):
    try:
        conv_table = dict(zip(polski, ikslop))
        result_as_chars = (conv_table[char] for char in s)
        return ''.join(result_as_chars)
    except:
        return

print(szyfr("SZUM"))

lista = {}
with open('slownik.txt', encoding='utf8') as f:
    for line in f:
        lines = line.split()
        for word in lines:
            word = word.replace(',',"")
            if len(word) == 4:
                word = word.upper()
                if "V" or "X" or "." or "-" not in word:
                    cip = szyfr(str(word))
                    cip = str(cip)
                    #print(word + " = " + cip)
                    lista[word] = cip

#print(lista)
for key, value in lista.items():
    if value in lista:
        print(key, " -> ", value)
