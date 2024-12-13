# Documentação do Jogo: **Batalha de Monstros**

**Integrantes:** David, Gabriel Eliezer, José.

## Introdução

O jogo *Batalha de Monstros* é uma aplicação de console que simula batalhas entre jogadores e/ou IA utilizando um sistema de combate por turnos. O projeto foi implementado em C# e emprega diversos *Design Patterns* para garantir modularidade, organização e escalabilidade.

## Funcionalidades Principais

- **Criação de Monstros:** Permite escolher entre diferentes tipos de monstros, cada um com atributos e habilidades específicas.
- **Combate por Turnos:** Os jogadores alternam ações como atacar, defender e usar habilidades especiais.
- **Modo PvP:** Dois jogadores podem jogar entre si.
- **Modo PvE:** Um jogador pode enfrentar um inimigo controlado pela IA(Não implementado).
- **Sistema de Pontuação:** A cada vitória, pontos são atribuídos aos jogadores.

---

## Estrutura do Código

### Classes Principais

1. **`Monster`**
   - Representa a entidade base dos monstros.
   - Contém atributos como `Health`, `AttackPower` e métodos para ações como `Attack`, `Defend` e `SpecialAbility`.

2. **`MonsterFactory`**
   - Implementa o padrão **Factory**, permitindo a criação de diferentes tipos de monstros de forma modular.

3. **`GameController`**
   - Centraliza a lógica do jogo, controlando os turnos e interações entre os jogadores e os monstros.
   - Implementa lógica de IA para o modo PvE.

4. **`SistemaPontuacao`**(Adicionado mas não funcional)
   - Implementa o padrão **Singleton** para garantir uma única instância que gerencia a pontuação durante a execução do jogo.

5. **`ControladorDeTurnos`**
   - Interface que define métodos para diferentes estratégias de combate (ataque, defesa, habilidades especiais).
   - Cada ação de combate é implementada como uma classe concreta, utilizando o padrão **Strategy**.

---

## Padrões de Design Utilizados

### 1. **Factory**
- **Descrição:** Centraliza a criação de objetos.
- **Uso no Jogo:** Criação de diferentes tipos de monstros (Dragão, Zumbi, etc.) através da classe `MonsterFactory`.

### 2. **Strategy**
- **Descrição:** Define uma família de algoritmos, encapsula cada um e os torna intercambiáveis.
- **Uso no Jogo:** Implementação de diferentes ações de combate como atacar, defender e usar habilidades especiais.

### 3. **Singleton**
- **Descrição:** Garante que uma classe tenha apenas uma instância e fornece um ponto global de acesso a ela.
- **Uso no Jogo:** Gerenciamento de pontuação através da classe `SistemaPontuacao`.

### 4. **Observer**
- **Descrição:** Permite que múltiplos objetos sejam notificados sobre mudanças de estado.
- **Uso Potencial:** Para notificar os jogadores sobre mudanças no estado do jogo, como a redução de vida dos monstros.

---

## Como Jogar

1. Escolha um modo no menu inicial:
   - PvP: Dois jogadores controlam seus respectivos monstros.
   - PvE: Um jogador enfrenta a IA(Não implementado).
2. Cada jogador realiza ações em turnos:
   - Atacar: Diminui a vida do adversário com base no ataque e na defesa.
   - Defender: Reduz o dano recebido no próximo ataque.
   - Habilidade Especial: Ativa a habilidade única do monstro.
3. O jogo termina quando todos os monstros de um jogador são derrotados.

---

## Futuras Melhorias

- Adicionar um sistema de salvamento e carregamento de progresso.
- Expandir o repertório de monstros e habilidades.
- Adicionar e Melhorar a inteligência artificial para estratégias mais avançadas no modo PvE.

---

## Conclusão

O projeto *Batalha de Monstros* exemplifica a aplicação prática de *Design Patterns* em jogos, mostrando como uma boa arquitetura pode facilitar a criação de funcionalidades robustas e escaláveis.
