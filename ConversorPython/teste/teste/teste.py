# ENTRADA DE DADOS -----------------------------------------------------------------
contador = 0
Dados_Info = str(input("Informe o que Deseja Converter: "))
dados = Dados_Info.upper().strip()
#ALFABETO MORSE --------------------------------------------------------------------------------
alfabeto_Morse = [".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--",
                  "-.","---",".--.","--.-",".-.","...","-",
                  "..-","...-",".--","-..-","-.--","--.."]
# ALFABETO NORMAL ----------------------------------------------------------------------------
alfabeto_Normal = ["A","B","C","D","E","F","G","H","I","J","K","L","M",
                   "N","O","P","Q","R","S","T","U","V","W","X","Y","Z"]

# VERIFICAÇÃO DE DADOS --------------------------------------------------------------------------

'''
if "L" in alfabeto_Normal:
    print(dados[contador].find("L"))
    print(dados[contador].find("U"))
    '''
while contador <= len(dados):
    contador+=1
    dad = dados[contador]
    print(dad)