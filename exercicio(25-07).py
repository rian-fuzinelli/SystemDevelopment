import random 

print("Sorteio!")

numeroran = random.randint(1, 10)

i = 1 
while i < 6:
    numero = int(input("Digite um número de 1 a 10:"))
    
    if numeroran == numero:
        print("acertou")
        break
    
    elif numero > 10:
        print("Numero inexistente")
        
    else:
        print("errou")
        
    i += 1
    
    print(numeroran)
