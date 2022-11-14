# Arrays

### Introduktion

En array i programmerings sammanhang är en lagring av information i ett linjärt format. Som är positionshanterat där första positionen har index 0 och nästföljande har position 1 osv...

Om vi skapar en array så är den låst till den storleken som vi initierar den till, t ex
`int[] numbers = new int[5]`
Detta skapar en array som kan lagra 5 heltal men inte fler.

#### Problem med array'er

Vi har två huvudsakliga problem med array'er:

1. Den är låst till den storleken som vi sätter i initeringen.
   Det är omöjligt att dynamiskt ändra storleken uppåt.
2. Om vi skapar en för stor array slösar vi med minne.
   Det är omöjligt att dynamiskt minska storleken.

#### Hur kan vi då ändra storleken på en array?

För att ändra storleken på en array uppåt eller neråt måste vi göra detta i fyra steg.

1. Först skapa en kopia där vi kan lagra informationen
1. Kopiera informationen ifrån vår array till vår kopia
1. Initiera om vår ursprungsarray till ny storlek.
1. Kopiera in informationen ifrån vår kopia till vår ominitierade array.

**Steg 1.**

`int[] copy = new int[numbers.Length];`

**Steg 2.**

`numbers.CopyTo(copy, 0);`

_CopyTo är en metod som finns på alla array typer och tar två argument:_ destinationen dit vi ska kopiera informationen och ifrån vilken position som vi ska börja kopiera.
I exemplet så kopierar vi ifrån position(index) 0, vilket låter oss kopiera alla element ifrån vår ursprungsarray.

**Steg 3.**

`numbers = new int[10];`

Nu har vi ominiterat vår array till att kunna hantera 10 heltal.

**Steg 4.**

`copy.CopyTo(numbers, 0);`

Här kopierar vi nu det som vi lagrade undan i vår kopia och återför informationen till vår numbers array.

###Ett smidigare sätt att skapa en kopia av en array
I version 8.0 av C# fick ett smidigare eller en kortare syntax för att kopiera en array till en annan.
`int[] copy = numbers[..];`
I JavaScript kallas denna syntax för _spread_ operatorn. Fast i JavaScript använder vi tre punkter.

Detta skapar en exakt kopia av en array och placerar detta i en ny array med exakt det antal element som finns i ursprungs array'en.

Så vi skulle kunna ersätta _CopyTo_ i **steg 2**. Tyvärr går denna teknik inte att använda i **steg 4**. För om vi skulle skriva följande kommando:
`numbers = copy[..];`
Så skulle vår numbers array ominitieras igen till det antal element som finns i vår copy array.
Fastän det är en smidig syntax så kom ihåg att vi får en exakt kopia av käll array'en till vår destinations array.
