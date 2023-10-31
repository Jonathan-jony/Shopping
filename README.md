﻿# 226_Shopping

<<<<<<< HEAD
226_SHopping is a C# library for dealing with sequence diagram.

## Installation

Use the package manager [pip](https://pip.pypa.io/en/stable/) to install foobar.

```bash
pip install foobar
```

## Usage

```python
import foobar

# returns 'words'
foobar.pluralize('word')

# returns 'geese'
foobar.pluralize('goose')

# returns 'phenomenon'
foobar.singularize('phenomena')
```

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License
[MIT](https://choosealicense.com/licenses/mit/)
=======
Ce petit projet permet l'entrainement à la POO ainsi qu'au développement orienté par les tests (TDD).

## Installation

## Pré-requis

* Visual Studio 2022 Enterprise Edition
* Git SCM (for Windows), dernière version

### Première compilation
Après avoir "clone" le dépôt sur la branche main, vous pouvez tenter une première compilation qui devrait vous donner ce résultat:

[INPUT]

Menu: Build->Build Solution

[OUTPUT]
```
3>Done building project "TestShopping.csproj".
========== Rebuild All: 3 succeeded, 0 failed, 0 skipped ==========
========== Rebuild started at 13:21 and took 00.747 seconds ==========
```
### Exécuter les tests

Pour afficher l'explorateur de test:
MENU : Test-> Test Explorer

[INPUT]

![image](https://github.com/CPNV-226a/Shopping/assets/5616312/4d05053e-f261-41a3-b445-f6d79bf80eb1)

[OUTPUT]

![image](https://github.com/CPNV-226a/Shopping/assets/5616312/182d2ce6-f4aa-465a-be9c-0215d458ee7c)

Vous obtenez tous les tests en échecs présentant le même message d'erreur:
"System.NotImplementedException:[...]"

Cela prouve que votre projet se compile et que les tests sont opérationnels.

## Pour s'entraîner

Le dépôt est constitué de 4 branches:

```
--main                  //état de départ, mais il est préférable de partir sur develop
--develop               //état de départ, la branche de base pour débuter votre entrainement
--feature/Cart          //la solution pour Cart (intégrant aussi bien CartItem que Article)
--feature/CartItem      //la solution pour CartItem (intégrant aussi Article)
--feature/Article       //la solution pour Article
```
Le contenu de main est identique à develop. Vous pouvez débuter l'entrainement sur l'une ou l'autre, même si les bonnes pratiques nous poussent à utiliser *develop*.

Via votre terminal, lancer la commande suivante:
```
git switch develop
```
Les fonctionnalités doivent être réalisées dans ce sens :

```
Article->CartItem->Cart
```

Soit vous utilisez git pour passer d'une branche à l'autre, soit vous pouvez vous aider de Github pour aller voir le contenu:

* [lien pour voir le contenu de la feature/Article](https://github.com/CPNV-226a/Shopping/tree/feature/Article)
* [lien pour voir le contenu de la feature/CartItem](https://github.com/CPNV-226a/Shopping/tree/feature/CartItem)
* [lien pour voir le contenu de la feature/Cart](https://github.com/CPNV-226a/Shopping/tree/feature/Cart)
 
## Demander le l'aide

* [Ouvrir une issue](https://github.com/CPNV-226a/Shopping/issues)

## License
[LICENCE](./LICENCE)
>>>>>>> 1ed100d099a987c382ca66ddd3d9e836ae89a7c1
