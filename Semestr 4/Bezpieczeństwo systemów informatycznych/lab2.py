height = 1920
width = 1080

all_bits = 1920 * 1080 * 24
print("-"*50)
print("Wszystkie bity: ", all_bits)

r_taken = 2
g_taken = 1
b_taken = 5

sum_rgb = r_taken + g_taken + b_taken
available_bits = 1920 * 1080 * (24 - sum_rgb)
print("Wszystkie bity dostępne dla obrazu: ", available_bits)

available_hide_bits = all_bits - available_bits
print("Wszystkie bity dostępne do ukrycia: ", available_hide_bits)

print("-"*50)
print("Znaki 7 bit (ASCII): ", available_hide_bits/7)
print("Znaki 8 bit (ASCII rozszerzone): ", available_hide_bits/8)
print("Znaki 16 bit (Unicode): ", available_hide_bits/8/2)
print("Bity (b): ", available_hide_bits)
print("Bajty (B): ", available_hide_bits/8)
print("KiloBajty (KB): ", available_hide_bits/8/1024)
print("MegaBajty (MB): ", available_hide_bits/8/1024/1024)
print("-"*50)