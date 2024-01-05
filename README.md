# Programmation Sup

## Comment lancer le serveur en local ?

Vous aurez besoin du package [`hugo`](https://github.com/gohugoio/hugo)

Ensuite, il faudra charger le thème du site : `git submodule update --init themes/PaperMod/`

Enfin, vous pourrez lancer le serveur en local avec la commande : `hugo server`

## Comment créer un nouveau sujet ?

Il suffit de taper cette commande : 
```
hugo new -k sujet [b1-b2-b3-b4]/[nom_du_sujet]
```

Vous pouvez ensuite vous rendre dans le dossier nouvellement créé 
(`content/[s1-s2]/nom_du_sujet`) et modifier le fichier `index.md` comme bon
vous semble. 

Si vous souhaitez intégrer des images à votre sujet, n'hésitez pas à les stocker
dans le sous dossier `resources/images`. Si vous avez fait une ref, vous pouvez
la stocker dans le dossier `resources/ref` ! 

