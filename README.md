# Gestionnaire de notes – Version 1

Ce projet est une mini‑application console en C# permettant de gérer les notes d’une classe d’étudiants.  
Il s’inspire d’un exercice guidé Microsoft Learn et constitue une excellente base pour pratiquer les fondamentaux du langage.

---

## 🚀 Fonctionnalités

- Ajouter un étudiant avec une liste de notes  
- Calculer automatiquement :
  - la somme des notes  
  - la moyenne  
  - la meilleure note  
  - la pire note  
- Afficher un bulletin formaté dans la console  
- Exporter tous les bulletins dans un fichier `.txt`  

---

## 📘 Exemple de sortie

```bash
Bulletin de Sophia
------------------
Notes : 93, 87, 98, 95, 100
Somme : 473
Moyenne : 94.6
Meilleure note : 100
Pire note : 87
```

---

## 🛠️ Technologies utilisées

- C#  
- .NET (console)  
- VS Code  

---

## 📁 Structure du projet

```bash
GradeManagerV1/
│
├── Program.cs
├── Student.cs
└── bulletins.txt (généré après export)
```

---

## ▶️ Exécution

Dans le dossier du projet :

```bash
dotnet run
```

---

## 📤 Export des bulletins

L’option du menu *“Exporter les bulletins dans un fichier”* génère automatiquement un fichier :

``` bash
bulletins.txt
```

contenant tous les bulletins formatés.

---

## 🎯 Objectifs pédagogiques

Ce projet permet de pratiquer :

- la création de classes  
- les listes (`List<int>`)  
- les propriétés calculées  
- les boucles et conditions  
- l’interaction console  
- l’écriture dans un fichier  
- la structuration d’un petit programme  

---

## Auteur

Projet réalisé par **Honnygloire MBOMBOTO TO HOUNDA**  
