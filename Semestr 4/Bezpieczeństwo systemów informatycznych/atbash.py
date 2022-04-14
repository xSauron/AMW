import re



def deszyfr(s):
    polski = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    ikslop = polski[::-1]
    try:
        mapa = dict(zip(polski, ikslop))
        char = (mapa[char] for char in s)
        return ''.join(char)
    except:
        return

word = "MVNLHRMVERGRRHVHG"
print(word + " = " + deszyfr(word))


