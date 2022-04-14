from pylfsr import LFSR


stan = [0,1,0,1,0,1,0]
xor = [1,5,7]

L = LFSR(initstate=stan,fpoly=xor)

print('Iteracja \t Stan \t\t\t Bit wyjsciowy \tSekwencja')
print('\t\t 1 2 3 4 5 6 7 ')
for _ in range(24):
    print(L.count,L.state,'',L.outbit,L.seq,sep='\t\t')
    L.next()
print('Wyjscie: ',L.seq)

L.Viz(show=False, show_labels=False,title='R1')