from Crypto.Hash import MD4, MD5,SHA1, SHA256, SHA512

def md5_hash(file):
    md5 = MD5.new()
    with open(file, 'rb') as f:
        while True:
            data = f.read(65536)
            if not data:
                break
            md5.update(data)
    return md5.hexdigest()

def sha1_hash(file):
    sha1 = SHA1.new()
    with open(file, 'rb') as f:
        while True:
            data = f.read(65536)
            if not data:
                break
            sha1.update(data)
    return sha1.hexdigest()

name = b'Jasek'

print("-"*20 + " ZAD 1 " + "-"*20)
md4 = MD4.new()
md4.update(name)
bin_1 = bin(int(md4.hexdigest(), 16))[2:].zfill(8)
print("MD4:     " + md4.hexdigest())
#print("BIN:     " + bin_1)
print("")

md5 = MD5.new()
md5.update(name)
bin_2 = bin(int(md5.hexdigest(), 16))[2:].zfill(8)
print("MD5:     " + md5.hexdigest())
#print("BIN:     " + bin_2)
print("")

sha1 = SHA1.new()
sha1.update(name)
bin_3 = bin(int(sha1.hexdigest(), 16))[2:].zfill(8)
print("SHA1:    " + sha1.hexdigest())
#print("BIN:     " + bin_3)
print("")

sha256 = SHA256.new()
sha256.update(name)
bin_4 = bin(int(sha256.hexdigest(), 16))[2:].zfill(8)
print("SHA256:  " + sha256.hexdigest())
#print("BIN:     " + bin_4)
print("")

sha512 = SHA512.new()
sha512.update(name)
bin_5 = bin(int(sha512.hexdigest(), 16))[2:].zfill(8)
print("SHA512:  " + sha512.hexdigest())
#print("BIN:     " + bin_5)
print("")

md4 = MD4.new()
md5 = MD5.new()
sha1 = SHA1.new()
sha256 = SHA256.new()
sha512 = SHA512.new()

namech = b'Jasej'

print("-"*20 + " ZAD 2 " + "-"*20)
md4.update(namech)
print("MD4:     " + md4.hexdigest())
bin_2_1 = bin(int(md4.hexdigest(), 16))[2:].zfill(8)
#print("BIN:     " + bin_2_1)
print("")

md5.update(namech)
print("MD5:     " + md5.hexdigest())
bin_2_2 = bin(int(md5.hexdigest(), 16))[2:].zfill(8)
#print("BIN:     " + bin_2_2)
print("")

sha1.update(namech)
print("SHA1:    " + sha1.hexdigest())
bin_2_3 = bin(int(sha1.hexdigest(), 16))[2:].zfill(8)
#print("BIN:     " + bin_2_3)
print("")

sha256.update(namech)
print("SHA256:  " + sha256.hexdigest())
bin_2_4 = bin(int(sha256.hexdigest(), 16))[2:].zfill(8)
#print("BIN:     " + bin_2_4)
print("")

sha512.update(namech)
print("SHA512:  " + sha512.hexdigest())
bin_2_5 = bin(int(sha512.hexdigest(), 16))[2:].zfill(8)
#print("BIN:     " + bin_2_5)
print("")

print("-"*20 + " PORÓWNANIE " + "-"*20)
print("MD4:  ")
bin_diff1 = int(bin_1, 2) ^ int(bin_2_1, 2)
bin_diff1_str = '{0:b}'.format(bin_diff1)
n_1 = bin_diff1_str.count("1")
n_0 = bin_diff1_str.count("0")
n_s = 128
print("1: ",n_1)
print("0: ",n_0)
print("S: ",n_s)
print(n_1/n_s * 100)
print()

print("MD5:  ")
bin_diff2 = int(bin_2, 2) ^ int(bin_2_2, 2)
bin_diff2_str = '{0:b}'.format(bin_diff2)
n_1 = bin_diff2_str.count("1")
n_0 = bin_diff2_str.count("0")
n_s = 128
print("1: ", n_1)
print("0: ", n_0)
print("S: ", n_s)
print(n_1/n_s * 100)
print()

print("SHA1:  ")
bin_diff3 = int(bin_3, 2) ^ int(bin_2_3, 2)
bin_diff3_str = '{0:b}'.format(bin_diff3)
n_1 = bin_diff3_str.count("1")
n_0 = bin_diff3_str.count("0")
n_s = 160
print("1: ", n_1)
print("0: ", n_0)
print("S: ", n_s)
print(n_1/n_s * 100)
print()

print("SHA256:  ")
bin_diff4 = int(bin_4, 2) ^ int(bin_2_4, 2)
bin_diff4_str = '{0:b}'.format(bin_diff4)
n_1 = bin_diff4_str.count("1")
n_0 = bin_diff4_str.count("0")
n_s = 256
print("1: ", n_1)
print("0: ", n_0)
print("S: ", n_s)
print(n_1/n_s * 100)
print()

print("SHA512:  ")
bin_diff5 = int(bin_5, 2) ^ int(bin_2_5, 2)
bin_diff5_str = '{0:b}'.format(bin_diff5)
n_1 = bin_diff5_str.count("1")
n_0 = bin_diff5_str.count("0")
n_s = 512
print("1: ", n_1)
print("0: ", n_0)
print("S: ", n_s)
print(n_1/n_s * 100)
print()

md5 = MD5.new()
print("-"*20 + " ZAD 3 " + "-"*20)
print("plane:   " + md5_hash("lab4/plane.jpg"))
print("ship:    " + md5_hash("lab4/ship.jpg"))
print()

print("-"*20 + " ZAD 4 " + "-"*20)
print("Hello1:     " + md5_hash("lab4/hello 1.exe"))
print("Hello2:     " + md5_hash("lab4/hello 2.exe"))
print()

print("-"*20 + " ZAD 5 " + "-"*20)
print("Oprah:   " + md5_hash("lab4/Oprah Winfrey.pdf"))
print("Jeb:     " + md5_hash("lab4/Jeb Bush.pdf"))
print("Al:      " + md5_hash("lab4/Al Gore.pdf"))
print("Paris:   " + md5_hash("lab4/Paris Hilton.pdf"))
print()

print("-"*20 + " ZAD 6 " + "-"*20)
print("shattered-1: " + sha1_hash("lab4/shattered-1.pdf"))
print("shattered-2: " + sha1_hash("lab4/shattered-2.pdf"))
print()

print("-"*20 + " ZAD 7 " + "-"*20)
print("jasek1:   " + md5_hash("lab4/jasek1.txt"))
print("jasek2:     " + md5_hash("lab4/jasek2.txt"))
print()