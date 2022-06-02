def nwd(a, b):
    while b:
        a, b = b, a % b
    return a


def generate_keys(p, q):
    n = p * q
    fi = (p - 1) * (q - 1)
    e = q + 1
    while nwd(e, fi) != 1:
        e += 1
    d = 1
    while (e * d) % fi != 1:
        d += 1
    return n, e, d

p = 19
q = 101
n, e, d = generate_keys(p, q)

print("n = ", n)
print("Klucz publiczny (e) = ", e)
print("Klucz prywatny (d) = ", d)


slowo = "wiosna"
szyfr = []
for litera in slowo:
    szyfr.append(pow(ord(litera), e, n))
print(szyfr)

for litera in szyfr:
    print(chr(pow(litera, d, n)), end="")