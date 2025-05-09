Mode d'emploi : Déploiement et Utilisation de l'Application ASP.NET Core avec SQL Server

1)	Créer la base de données avant DB_PRODUIT et Restaurer la base SQL avec SSMS (basededonneesLabonneversion.SQL et meublestyledata.sql)
2)	Modifier appsetting.json avec la bonne chaîne de connexion si nécessaire
3)	Lancer l’application via Visual Studio
4)	Utiliser et tester l’application
5)	
Comment restaurer une base à partir d’un fichier .sql
1. Exécuter le script .sql
•	Ouvre ton fichier .sql (File > Open > choisir ton fichier).
•	Exécute tout le script (F5).
Ce que fait le script :
•	Crée la base de données
•	Crée les tables
•	Crée les contraintes, index
•	(Parfois) insère aussi les données (INSERT INTO...)
