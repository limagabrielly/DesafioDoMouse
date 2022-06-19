# DesafioDoMouse

====Descrição====:
Criar um sistema, em janela console, onde o usuário controle o mouse do computador. 

Ou seja, o sistema deve exibir:

- A posição atual
- Todas as movimentações possíveis (independente se é permitida ou não) e o usuário escolhe qual quer realizar.
- Uma mensagem de erro caso a movimentação escolhida não seja possível.

====Regras====
O mouse pode se MOVER nas seguintes direções:
- Direita 
- Esquerda
- Cima
- Baixo

_

O mouse pode ESTAR nas seguintes posições:

- Cima e Esquerda
- Cima e Centro
- Cima e Direita
- Centro e Esquerda
- Centro
- Centro e Direita
- Baixo e Esquerda
- Baixo e Centro
- Baixo e Direita

Montando o seguinte desenho.
![image](https://user-images.githubusercontent.com/99194235/174492924-be4d0bc4-6a21-40bc-b0cb-3810b32d1ad7.png)

__

O mouse sempre inicia na posição: Centro. 
__

O mouse não pode fazer movimentos impossíveis.

Por exemplo: Estar na posição "Centro e Direita" e tentar ir para a direita (Não tem mais como ir). 

Mas pode se mover pra cima nesse caso. (Pois vai parar em "Cima e Direita")
