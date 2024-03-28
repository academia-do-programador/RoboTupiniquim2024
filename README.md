
# Rob� Tupiniquim

A AEB (Ag�ncia Espacial Brasileira) entrou em contato com a turma da Academia do Programador 2024 para realiza��o de um novo projeto.�

A ag�ncia est� planejando uma expedi��o � Marte, mas antes, a AEB vai enviar uma nave espacial (codinome Tupiniquim I) tripulada com um Rob� para fazer an�lises do planeta vermelho. Os alunos da 10� edi��o da Academia do Programador, reconhecidos como excelentes programadores, foram contratados para desenvolver o software que ir� guiar o Rob� nesta empreitada.

---
## Detalhes

A �rea escolhida para an�lise � curiosamente retangular e os rob�s devem andar por ela com suas c�meras ligadas coletando todo tipo de informa��o. A posi��o de um rob� � representada por uma combina��o de coordenadas X e Y e tamb�m uma letra representando a dire��o que ele est� olhando. A �rea � dividida em um grid para simplificar a navega��o. Um exemplo de posi��o poderia ser: 0,0,N, significando o rob� est� na parte inferior esquerda com a face para o norte. Use as orienta��es: N =norte, S = sul, L = leste, O = oeste.��

Para controlar o rob�, a AEB envia simples strings com os comandos. Letras poss�veis s�o: E, D e M. As letras E e D fazem o rob� virar 90 graus para esquerda e direita respectivamente, sem sair do lugar. A letra M significa se mover uma posi��o no grid para frente, mantendo a mesma dire��o.��

Assuma que mover o rob� para frente, significa mover sua posi��o de (X, Y) para (X, Y+1). Por exemplo, um rob� na posi��o (0,0) com a face para o norte, ao se mover uma posi��o, vai parar em (0,1).

---
## Entrada

```
5 5
1 2 N
EMEMEMEMM
3 3 L
MMDMMDMDDM
```
## Sa�da

```
1 3 N
5 1 L
```
---
## Funcionalidades

- Recebe como entrada o tamanho do plano de coordenadas.
- Solicita as coordenadas iniciais e as ordens de movimento para um determinado n�mero de rob�s.
- Executa as ordens de movimento para cada rob�.
- Atualiza a posi��o e dire��o de cada rob� conforme as ordens de movimento.
- Imprime a posi��o final de cada rob� ap�s a execu��o das ordens.
---
## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compila��o e execu��o do projeto.
---
## Como Usar

1. Clone o reposit�rio ou baixe o c�digo fonte do projeto.
2. Abra ou terminal ou o prompt de comando e navegue at� a pasta raiz da solu��o.
3. Utilize o comando abaixo para restaurar as depend�ncias do projeto.

```
dotnet restore
```

4. Em seguida, compile a solu��o utilizando o comando:
   
```
dotnet build --configuration Release
```

5. Para executar o projeto compilando em tempo real
   
```
dotnet run --project RoboTupiniquim.ConsoleApp
```

6. Para executar o arquivo compilado, navegue at� a pasta `./RoboTupiniquim.ConsoleApp/bin/Release/net8.0/` e execute o arquivo:
   
```
RoboTupiniquim.ConsoleApp.exe
```