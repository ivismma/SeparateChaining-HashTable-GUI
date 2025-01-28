# Separate Chaining Hash Table - GUI

Esse é um miniprojeto com o foco mais voltado para a minha prática de POO em C# do que a a tabela hash em si.

Embora o [framework .NET do Windows.Forms](https://www.geeksforgeeks.org/introduction-to-c-sharp-windows-forms-applications/) tenha um objetivo e propósito simples, cheguei a conclusão que ele ainda
requer um pouco de planejamento no código para manter uma boa interação humano-computador e responsividade
na aplicação, isso tornou o desenvolvimento mais interessante e divertido (seria entediante se não houvesse
esse fato). O tratamento de input's no comportamento do programa é legal de se construir.

A estrutura de dados em questão é uma [Tabela de Dispersão](https://en.wikipedia.org/wiki/Hash_table) com tratamento de colisão por [Encadeamento Externo](https://en.wikipedia.org/wiki/Hash_table#Separate_chaining).
Seu propósito é alocar um **vetor de Listas encadeadas** e distribuir as chaves da maneira mais eficiente possível.<br>
Existem outros métodos de [tratamento de colisões](https://en.wikipedia.org/wiki/Hash_table#Collision_resolution) além do encadeamento externo.
(a fim de evitar a menor quantidade de [colisões](https://en.wikipedia.org/wiki/Hash_collision)).<br>
Nesse programa, deixei possível a utilização de dois métodos de [hashing](https://en.wikipedia.org/wiki/Hash_table#Hash_function):
- [Método da divisão](https://en.wikipedia.org/wiki/Hash_table#Hashing_by_division) (básico, apenas para fácil entendimento. Nesse programa, divide-se pelo resto do tamanho tabela (8),
existem métodos mais eficientes).
- [Método da multiplicação](https://en.wikipedia.org/wiki/Hash_table#Hashing_by_multiplication) (eficiente. Nesse programa, ocorre multiplicação por uma constante e bit mixing).

O programa oferece alguns recursos:<br>
> Definição de regras de comportamento da estrutura de dados;<br>
> Inserção de chaves (que são do tipo Int32);<br>
> Remoção de chaves;<br>
> Reinicialização da tabela de dispersão;<br>
> Visualização em tempo real da tabela hash e os encadeamentos, bem como os dados armazenados (que são apenas inteiros).<br>

Para as listas encadeadas, as classes [LinkedList\<T\>](https://learn.microsoft.com/pt-br/dotnet/api/system.collections.generic.linkedlist-1?view=net-8.0) e [LinkedListNode\<T\>](https://learn.microsoft.com/pt-br/dotnet/api/system.collections.generic.linkedlistnode-1?view=net-8.0) foram utilizadas no desenvolvimento de algumas funções de gerenciamento dos encadeamentos. As inserções (não ordenadas) são sempre feitas no
fim das listas, isso porque a LinkedList do C# é uma [Lista Duplamente Encadeada](https://en.wikipedia.org/wiki/Doubly_linked_list) então temos um ponteiro para o final. Caso não fosse, seria imprescindível inserir no início como um push(), mantendo sempre complexidade O(1) nas inserções. <br>
Idealmente, o tratamento por encadeamento externo em listas duplamente encadeadas é desnecessário, pois não traz utilidade alguma, apenas aumenta a **complexidade de espaço**. Sendo assim, listas
simplesmente encadeadas já bastam.

Sobre a aba de alteração das regras da estrutura de dados:
- **Inserção ordenada**: Fará com que o método de inserção seja modificado com o objetivo de manter os encadeamentos ordenados.
Útil quando a ordenação é necessária. A ativação dessa regra não só mantém as listas ordenadas como também altera a lógica
por trás das inserções/remoções, melhorando um pouco a busca e remoção.
Como condição para a alteração dessa regra, defini que não deverá existir nenhuma lista com mais do que um elemento.
- **Função Hash**: Como mencionado um pouco acima, altera a função hash. Obs: Ambos extraem o valor absoluto (abs) da chave.
Como condição para alteração dessa regra, defini que a tabela deve estar inutilizada/completamente vazia.

Muitas informações usadas foram tiradas do livro ao qual estudei Estruturas de Dados:<br>
**Estruturas de Dados e Seus Algoritmos - 3º edição | Markezon e Szwarcfiter**<br>
Esse livro fala muito bem de Hash Tables e muitas outras estruturas de dados.

Obrigado pela leitura!
