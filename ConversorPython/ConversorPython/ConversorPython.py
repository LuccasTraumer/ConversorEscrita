''' Conversor de Morse e Numeral em Python '''
print("-==--=-=---=-=--=-=-=--=-=--=-=-=-=-=-=--==")
print("        Projeto Luccas Traumer             ")
print("-==--=-=---=-=--=-=-=--=-=--=-=-=-=-=-=--==")
print("    Digite (Morse) para Conversor Morse    ")
print("        Digite (FIM) para Finalizar.       ")

DadosInformados = str(input("Dados a Ser Convertido: "))
dados = DadosInformados.upper().strip()
# ALFABETO NORMAL
alfabeto_Normal = ("A","B","C","D","E","F","G","H","I","J","K","L","M",
                   "N","O","P","Q","R","S","T","U","V","W","X","Y","Z"," ")
#ALFABETO MORSE
alfabeto_Morse = (".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--",
                  "-.","---",".--.","--.-",".-.","...","-",
                  "..-","...-",".--","-..-","-.--","--.."," ")
#ALFABETO NUMERAL
alfabeto_Numeral = ("0","1","2","3","4","5","6","7","8","9","10","11","12","13","14","15","16","17","18",
                    "19","20","21","22","23","24","25","26","27")

# Estruturada / TOMADAS DE DECISOES
contador = 0
contadorIndice = 0
letras = ""
palavras = ""
letrasMorse = ""
palavraMorse = ""
#Para deixar mais bonito visualmente.
print("-==-==- Caracter por Caracter.-=-=-==-")
print("Letra no Alfabeto         Cod.Morse   ")
#Processamento de Dados 
for letras in dados:
    letras = dados[contador]
    print(letras)
    if letras == "A":
        letrasMorse = ".-"
        print("                      ",letrasMorse)
    if letras == "B":
        letrasMorse = "-..."
        print("                      ",letrasMorse)
    if letras == "C":
        letrasMorse = "-.-."
        print("                      ",letrasMorse)
    if letras == "D":
        letrasMorse = "-.."
        print("                      ",letrasMorse)
    if letras == "E":
        letrasMorse = "."
        print("                      ",letrasMorse)
    if letras == "F":
        letrasMorse = "..-."
        print("                      ",letrasMorse)
    if letras == "G":
        letrasMorse = "--."
        print("                      ",letrasMorse)
    if letras == "H":
        letrasMorse = "...."
        print("                      ",letrasMorse)
    if letras == "I":
        letrasMorse = ".."
        print("                      ",letrasMorse)
    if letras == "J":
        letrasMorse = ".---"
        print("                      ",letrasMorse)
    if letras == "K":
        letrasMorse = "-.-"
        print("                      ",letrasMorse)
    if letras == "L":
        letrasMorse = ".-.."
        print("                      ",letrasMorse)
    if letras == "M":
        letrasMorse = "--"
        print("                      ",letrasMorse)
    if letras == "N":
        letrasMorse = "-."
        print("                      ",letrasMorse)
    if letras == "O":
        letrasMorse = "---"
        print("                      ",letrasMorse)
    if letras == "P":
        letrasMorse = ".--."
        print("                      ",letrasMorse)
    if letras == "Q":
        letrasMorse = "--.-"
        print("                      ",letrasMorse)
    if letras == "R":
        letrasMorse = ".-."
        print("                      ",letrasMorse)
    if letras == "S":
        letrasMorse = "..."
        print("                      ",letrasMorse)
    if letras == "T":
        letrasMorse = "-"
        print("                      ",letrasMorse)
    if letras == "U":
        letrasMorse = "..-"
        print("                      ",letrasMorse)
    if letras == "V":
        letrasMorse = "...-"
        print("                      ",letrasMorse)
    if letras == "W":
        letrasMorse = ".--"
        print("                      ",letrasMorse)
    if letras == "X":
        letrasMorse = "-..-"
        print("                      ",letrasMorse)
    if letras == "Y":
        letrasMorse = "-.--"
        print("                      ",letrasMorse)
    if letras == "Z":
        letrasMorse = "--.."
        print("                      ",letrasMorse)
    if letras == "1":
        letrasMorse = ".----"
        print("                      ",letrasMorse)
    if letras == "2":
        letrasMorse = "..---"
        print("                      ",letrasMorse)
    if letras == "3":
        letrasMorse = "...--"
        print("                      ",letrasMorse)
    if letras == "4":
        letrasMorse = "...."
        print("                      ",letrasMorse)
    if letras == "5":
        letrasMorse = "....."
        print("                      ",letrasMorse)
    if letras == "6":
        letrasMorse = "-...."
        print("                      ",letrasMorse)
    if letras == "7":
        letrasMorse = "--..."
        print("                      ",letrasMorse)
    if letras == "8":
        letrasMorse = "---.."
        print("                      ",letrasMorse)
    if letras == "9":
        letrasMorse = "----."
        print("                      ",letrasMorse)
    if letras == "0":
        letrasMorse = "-----"
        print("                      ",letrasMorse)
    if letras == " ":
        print(" ")

    contador+=1
    palavras += letras
    palavraMorse += letrasMorse
    
#Para deixar mais bonito visualmente.
print("-------- Palavras Completas.--=-=-=-=-")
print("Palavra                 Codigo Morse  ")
print(dados,"                   ",palavraMorse)

fim = str(input("Pressione [ENTER] para Finalizar."))