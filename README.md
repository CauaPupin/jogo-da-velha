# Documentação do Jogo da Velha

## Requisitos Funcionais

### RF01 - Jogador deve criar nova partida
O aplicativo deve cria uma nova partida, com o tamanho padrão 3x3 (linhas e colunas)

> Como jogador, gostaria de criar uma nova partida, com o número de linhas e colunas do tabuleiro igual a 3.

### RF02 - Jogador deve conseguir consultar uma partida existente
O aplicativo deve permitir que o jogador consulte uma partida em andamento para visualizar o estado atual do jogo.

> Eu, como jogador, gostaria de consultar uma partida existente para ver o progresso ou continuar jogando.

### RF03 - Jogador deve configurar uma jogada
O aplicativo deve permitir que o jogador faça uma jogada em uma posição específica do tabuleiro durante uma partida em andamento, atualizando o estado do jogo.

> Como jogador, gostaria de fazer uma jogada informando a posição no tabuleiro para atualizar o estado do jogo.

### RF04 - Jogador deve conseguir reiniciar uma partida
O aplicativo deve permitir que o jogador reinicie uma partida em andamento, começando do zero.

> Eu, como jogador, gostaria de reiniciar uma partida para jogar novamente desde o início.

### RF05 - Jogador deve listar todas as partidas em andamento
O aplicativo deve permitir que o jogador liste todas as partidas em andamento para escolher uma para consultar ou continuar jogando.

> Eu, como jogador, gostaria de ver todas as partidas em andamento para poder escolher uma para continuar ou consultar.

## Requisitos Não Funcionais

### RNF01 - O aplicativo deve gerar logs de jogadas
O aplicativo deve gerar logs das ações realizadas pelo jogador, incluindo o estado do jogo e as jogadas feitas.

## Regras de Negócio

- RN001: O tabuleiro do jogo deve ter pelo menos 3 linhas e 3 colunas.
- RN002: A cada jogada, o sistema deve verificar se o jogador ganhou ou se houve empate.
- RN003: O jogador só pode fazer uma jogada em uma posição que não tenha sido ocupada.
- RN004: O jogo deve alternar as jogadas entre os jogadores X e O.
- RN005: Se uma partida for reiniciada, o tabuleiro deve ser redefinido para o estado inicial.

## Modelo de Caso de Uso

### Atores

- **Jogador**: Qualquer pessoa que interage com o jogo através de uma interface disponível (linha de comando, web, etc.).

### Caso de Uso

#### CSU01: Criar partida
##### Requisitos
RF01
##### Importância
Alta: Sem essa funcionalidade, o jogo não pode ser iniciado.
##### Sumário
> O jogador solicita a criação de uma nova partida, definindo o número de linhas e colunas do tabuleiro.

##### Ator Primário
Jogador
##### Fluxo

| Jogador                       | Sistema                                    |
| ----------------------------- | ------------------------------------------ |
| Informa o número de linhas e colunas | Sistema cria a nova partida e retorna o ID |

##### Fluxo de Exceção
- **Erros de Usuário**: Se o número de linhas ou colunas for inválido, uma mensagem de erro será retornada.
- **Erros de Sistema**: Se ocorrer um problema técnico, uma mensagem de falha será exibida.

##### Pós-condições
O sistema cria e salva a nova partida em um repositório para futura consulta.

##### Regras de Negócio
RN001

---

#### CSU02: Consultar uma partida
##### Requisitos
RF02
##### Importância
Alta: Essencial para visualizar ou continuar uma partida existente.
##### Sumário
> O jogador consulta uma partida existente para ver o estado atual do jogo.

##### Ator Primário
Jogador
##### Fluxo

| Jogador              | Sistema                                      |
| -------------------- | -------------------------------------------- |
| Informa o ID da partida | Sistema retorna o estado atual da partida |

##### Fluxo de Exceção
- **Erros de Usuário**: Se o ID da partida for inválido, uma mensagem de erro será retornada.
- **Erros de Sistema**: Problemas técnicos serão comunicados ao jogador.

##### Pós-condições
O sistema retorna a partida no estado mais recente.

##### Regras de Negócio
N/A

---

#### CSU03: Fazer uma jogada
##### Requisitos
RF03
##### Importância
Alta: Permite que o jogo avance com as jogadas dos jogadores.
##### Sumário
> O jogador faz uma jogada em uma posição específica do tabuleiro.

##### Ator Primário
Jogador
##### Fluxo

| Jogador                 | Sistema                                         |
| ----------------------- | ----------------------------------------------- |
| Informa o ID da partida e a posição da jogada | Sistema valida a jogada e atualiza o estado do jogo |

##### Fluxo de Exceção
- **Erros de Usuário**: Jogada inválida ou posição ocupada resultam em mensagem de erro.
- **Erros de Sistema**: Problemas técnicos são comunicados ao jogador.

##### Pós-condições
O sistema atualiza e salva o estado do jogo após a jogada.

##### Regras de Negócio
RN003, RN004

---

#### CSU04: Reiniciar uma partida
##### Requisitos
RF04
##### Importância
Média: Permite ao jogador começar novamente uma partida existente.
##### Sumário
> O jogador reinicia uma partida em andamento.

##### Ator Primário
Jogador
##### Fluxo

| Jogador          | Sistema                                  |
| ---------------- | ---------------------------------------- |
| Solicita reinício da partida | Sistema redefine o tabuleiro e reinicia a partida |

##### Fluxo de Exceção
- **Erros de Usuário**: Problemas ao reiniciar são informados ao jogador.
- **Erros de Sistema**: Mensagens de falha técnica serão exibidas.

##### Pós-condições
O tabuleiro é redefinido e a partida é reiniciada.

##### Regras de Negócio
RN005

---

#### CSU05: Listar partidas em andamento
##### Requisitos
RF05
##### Importância
Média: Permite ao jogador ver todas as partidas ativas e escolher qual consultar ou continuar.
##### Sumário
> O jogador solicita a lista de todas as partidas em andamento.

##### Ator Primário
Jogador
##### Fluxo

| Jogador          | Sistema                            |
| ---------------- | ---------------------------------- |
| Solicita lista de partidas | Sistema retorna uma lista de partidas em andamento |

##### Fluxo de Exceção
- **Erros de Sistema**: Problemas técnicos resultam em mensagem de falha.

##### Pós-condições
O sistema retorna a lista de partidas em andamento.

##### Regras de Negócio
N/A

---

## Repositório

### Ferramentas

- [VS Code](https://code.visualstudio.com/)

### Referências