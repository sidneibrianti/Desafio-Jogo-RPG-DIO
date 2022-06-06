
##1º Desafio C#

Criando uma aplicativo RPG com pilares POO.

1. Abstração
2. Herança
3. Encapsulamento
4. Polimosfismo

Abaixo temos o Diagrama de Classe do aplicativo RPG.

![RPG](/ClassDiagram.png)

###Exemplos do Códigos usados

####Abstração

Aqui criamos uma classe __*Character*__ para abastrair as caracteristicas básico dos personagens.

####Herança:

A classe __*Hero*__ herdou todos as Atribuitos e Métodos da classe __*Character*__.

```csharp
// -------------------
// Exemplo de Herança
// -------------------
internal class Hero : Character
{
    public Hero(string name, int health, int attack, int defense,
    ClassType classtype, Races races) : base(name, health, attack, 
    defense, classtype, races)
    {
    }

    void Luck()
    {
        //ToDo
    }
    void Range()
    {
        //ToDo
    }
}
```

####Encapsulamento:

A mudança da vida do personagem só pode ser alterando dentro do classe onde esse atributo foi criado.

```csharp
// --------------------------
// Exemplo de Encapsulamento
// --------------------------
public bool Defending(int attack)
{
    
    int ataque = attack + Dices.OneDice(20);
    int defesa = Defense + Dices.OneDice(20);
    int dano = ataque - defesa;
    bool returnDefending = false;
    if (dano > 0)
    {
        _health -= dano;
        if (_health < 0)
            _health = 0;
        returnDefending = true;
        
    }
    return returnDefending;
}
```

####Polimosfismo:

Aqui mudamos a método __*ToString( )*__ da classe base __*Object*__.

```csharp
    // ------------------------
    // Exemplo de Polimosfismo
    // ------------------------
    public override string ToString()
    {
        return ($"Name: {Name}\n
                  Health: {Health}\n
                  Attack: {Attack}\n
                  Defense: {Defense}\n
                  ClassType: {ClassType}\n
                  Races: {Races}");
    }
```
