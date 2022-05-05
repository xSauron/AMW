from Crypto.Cipher import DES, AES
from Crypto.Util.Padding import pad, unpad

key = b'AMWBEST1'
key_2a = b'AMWBEST0'
key_2b = b'AMWBEST5'
key_2c = b'4MWB3ST1'
key_5 = b'AMWBEST1AMWBEST1AMWBEST1AMWBEST1'
print(key_5)

text = b'Adrian Jasek Adrian Jasek Adrian Jasek Adrian Jasek Adrian Jasek Adrian Jasek Adrian Jasek Adrian Jasek Adrian Jasek Adrian Jasek'
text_3 = b'Adriaann Jasekk Adriaann Jasekk Adriaann Jasekk Adriaann Jasekk Adriaann Jasekk Adriaann Jasekk Adriaann Jasekk Adriaann Jasekk Adriaann Jasekk Adriaann Jasekk'

des = DES.new(key, DES.MODE_ECB)
des_2a = DES.new(key_2a, DES.MODE_ECB)
des_2b = DES.new(key_2b, DES.MODE_ECB)
des_2c = DES.new(key_2c, DES.MODE_ECB)
des_4 = DES.new(key, DES.MODE_CBC, iv=b'\xb4\x18\x11\x18\xfb\xd0\xcaQ')
aes = AES.new(key_5, AES.MODE_ECB)

padded_text = pad(text,8)
padded_text_3 = pad(text_3, 8)
padded_text_aes = pad(text_3, 16)
encrypted_text = des.encrypt(padded_text)
encrypted_text_2a = des_2a.encrypt(padded_text)
encrypted_text_2b = des_2b.encrypt(padded_text)
encrypted_text_2c = des_2c.encrypt(padded_text)
encrypted_text_3 = des.encrypt(padded_text_3)
encrypted_text_4 = des_4.encrypt(padded_text_3)
encrypted_text_aes = aes.encrypt(padded_text_aes)

#Zapisy binarne
bin = str(bin(int(encrypted_text.hex(), 16)))[2:].zfill(8)
bin_2a = str(bin(int(encrypted_text_2a.hex(), 16)))[2:].zfill(8)
bin_2b = str(bin(int(encrypted_text_2b.hex(), 16)))[2:].zfill(8)
bin_2c = str(bin(int(encrypted_text_2c.hex(), 16)))[2:].zfill(8)
bin_3 = str(bin(int(encrypted_text_3.hex(), 16)))[2:].zfill(8)
bin_4 = str(bin(int(encrypted_text_4.hex(), 16)))[2:].zfill(8)

print("-"*20 + "ZASZYFROWANE" + "-"*20)
print(encrypted_text)
#print(encrypted_text.hex(" "))
print(encrypted_text.hex(" ").upper())
print(bin)
print("-"*20 + "ZASZYFROWANE 2A" + "-"*20)
print(encrypted_text_2a)
print(encrypted_text_2a.hex(" ").upper())
print(bin_2a)
print("-"*20 + "ZASZYFROWANE 2B" + "-"*20)
print(encrypted_text_2b)
print(encrypted_text_2b.hex(" ").upper())
print(bin_2b)
print("-"*20 + "ZASZYFROWANE 2C" + "-"*20)
print(encrypted_text_2c)
print(encrypted_text_2c.hex(" ").upper())
print(bin_2c)
print("-"*20 + "ZASZYFROWANE 3" + "-"*20)
print(encrypted_text_3)
print(encrypted_text_3.hex(" ").upper())
print(bin_3)

print("-"*20 + "PORÓWNANIE 1 z 2A" + "-"*20)
bin_diff1 = int(bin, 2) ^ int(bin_2a, 2)
print('{0:b}'.format(bin_diff1))

print("-"*20 + "PORÓWNANIE 1 z 2B" + "-"*20)
bin_diff2 = int(bin, 2) ^ int(bin_2b, 2)
bin_diff2_str = '{0:b}'.format(bin_diff2)
print(bin_diff2_str)
print(bin_diff2_str.count("1"))

print("-"*20 + "PORÓWNANIE 1 z 2C" + "-"*20)
bin_diff3 = int(bin, 2) ^ int(bin_2c, 2)
bin_diff3_str = '{0:b}'.format(bin_diff3)
print('{0:b}'.format(bin_diff3))
print(bin_diff3_str)
print(bin_diff3_str.count("1"))

print("-"*20 + "ZASZYFROWANE 4" + "-"*20)
print(des_4.iv)
print(des_4.iv.hex())
print(encrypted_text_4)
print(encrypted_text_4.hex(" ").upper())
print(bin_4)
print("-"*20 + "ZASZYFROWANE 5" + "-"*20)
print(encrypted_text_aes)
print(encrypted_text_aes.hex(" ").upper())
print(bin_4)
print("-"*20 + "DECRYPTED" + "-"*20)
decrypted_text = des.decrypt(encrypted_text)
print(decrypted_text)
print(decrypted_text.hex(' '))
#https://the-x.cn/en-US/cryptography/Des.aspx