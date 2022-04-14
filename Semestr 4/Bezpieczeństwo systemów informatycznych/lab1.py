import math

def szyfr_cezara(tekst, przesuniecie, uzyjPL):
    angielski = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    polski = "AĄBCĆDEĘFGHIJKLŁMNŃOÓPRSŚTUWYZŹŻ"
    tekst = tekst.upper()

    if uzyjPL:
        klucz = polski[przesuniecie:] + polski[0:przesuniecie]
    else:
        klucz = angielski[przesuniecie:] + angielski[0:przesuniecie]

    wynik = ""
    for znak in tekst:
        if znak == " ":
            wynik += " "
        else:
            wynik += klucz[polski.find(znak) if uzyjPL else angielski.find(znak)]

    return wynik

tekst = "Adrian Jasek"
#print(tekst, " = ", szyfr_cezara(tekst,7,False))

def atbash(slowo):
    polski = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    ikslop = polski[::-1]
    try:
        mapa = dict(zip(polski, ikslop))
        char = (mapa[char] for char in slowo)
        wynik = ''.join(char)
        return wynik
    except:
        return

tekst = "MVNLHRMVERGRRHVHG"
print(tekst + " = " + atbash(tekst))

def vigenere(tekst,klucz, decode):
    angielski = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    tekst = tekst.upper();
    klucz = klucz.upper();
    macierz = []
    wynik = ""


    for w in range(len(angielski)):
        wiersz = []
        for k in range(len(angielski)):
            wiersz.append(angielski[(k+w)%len(angielski)])

        macierz.append(wiersz)

    nowyklucz = klucz*math.ceil(len(tekst)/len(klucz))
    if len(nowyklucz) != len(tekst):
        nowyklucz = nowyklucz[:-(len(nowyklucz)-len(tekst))]

    test = len(nowyklucz) == len(tekst)

    if decode == False:
        for i in range(len(tekst)):
            if tekst[i] == " ":
                wynik += " "
            else:
                wynik += macierz[ord(tekst[i])-65][ord(nowyklucz[i])-65]
    elif decode == True:
        for i in range(len(tekst)):
            wynik += macierz[0][macierz[ord(nowyklucz[i])-65].index(tekst[i])]

    return wynik;

tekst = "PAOTVQCGJDMIJGREZPUFAM"
klucz = "AMW"
#print(tekst, " = ", vigenere(tekst,klucz, True))


def playfair(tekst, klucz, decode):
    macierz = []
    klucz = klucz.upper()
    tekst_s = tekst.upper()
    tekst = tekst_s.replace(" ", "")
    angielski = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"

    for char in klucz:
        if char == "I":
            char = "J"
        if char not in macierz:
            macierz.append(char)

    for char in angielski:
        if char != "I":
            if char not in macierz:
                macierz.append(char)

    macierz_g = []
    macierz_g.append(macierz[0:5])
    macierz_g.append(macierz[5:10])
    macierz_g.append(macierz[10:15])
    macierz_g.append(macierz[15:20])
    macierz_g.append(macierz[20:25])
    print(macierz_g)
    i = 0
    new = []
    for x in range(math.floor(len(tekst) / 2)):
        new.append(tekst[i:i + 2])
        i = i + 2
    tekst = new;

    def pozycja(m, char):
        x = y = 0
        for i in range(5):
            for j in range(5):
                if m[i][j] == char:
                    x = i
                    y = j

        return x, y

    zakodowana = []
    for char in tekst:
        p1, q1 = pozycja(macierz_g, char[0])
        p2, q2 = pozycja(macierz_g, char[1])

        #Ten sam wiersz
        if p1 == p2:
            if q1 == 4:
                q1 = -1
            if q2 == 4:
                q2 = -1
            zakodowana.append(macierz_g[p1][q1 + 1])
            zakodowana.append(macierz_g[p1][q2 + 1])
        # Ta sama kolumna
        elif q1 == q2:
            if p1 == 4:
                p1 = -1
            if p2 == 4:
                p2 = -1
            zakodowana.append(macierz_g[p1 + 1][q1])
            zakodowana.append(macierz_g[p2 + 1][q2])
        # Różny wiersz i kolumna
        else:
            zakodowana.append(macierz_g[p1][q2])
            zakodowana.append(macierz_g[p2][q1])

    wynik = "".join(zakodowana)

    for i in range(len(tekst_s)):
        if tekst_s[i] == " ":
            wynik = wynik[:i] + " " + wynik[i:]

    return wynik

tekst = "AMOR PATRIAE NOSTRA LEX"
klucz = "Jasek"

#print(tekst, " = ", playfair(tekst, klucz, False))


