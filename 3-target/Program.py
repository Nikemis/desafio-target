import json

def carregar_dados(nome_arquivo):
    
    with open(nome_arquivo, 'r') as arquivo:
        return json.load(arquivo)['faturamento']

def calcular_faturamento(dados):
   
    valores = [item['valor'] for item in dados if item['valor'] > 0]
    

    menor_valor = min(valores)
    maior_valor = max(valores)
    media_mensal = sum(valores) / len(valores)
    dias_acima_da_media = sum(1 for valor in valores if valor > media_mensal)

    return menor_valor, maior_valor, media_mensal, dias_acima_da_media

def main():
    nome_arquivo = 'faturamento.json'
    
    try:
        dados = carregar_dados(nome_arquivo)
        menor_valor, maior_valor, media_mensal, dias_acima_da_media = calcular_faturamento(dados)
        
        print(f"Menor valor de faturamento: R${menor_valor:.2f}")
        print(f"Maior valor de faturamento: R${maior_valor:.2f}")
        print(f"Média mensal de faturamento: R${media_mensal:.2f}")
        print(f"Número de dias com faturamento acima da média: {dias_acima_da_media}")
    
    except (FileNotFoundError, ValueError) as e:
        print(e)

if __name__ == "__main__":
    main()
