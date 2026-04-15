# CSharpAdminProgram
Hier lever ik mijn Admin Program opdracht in.

Administratie Programma Documentatie:
Dit programma is gemaakt wegens reden dat het een opdracht is, in dit programma kan je de volgende dingen doen:

Programma werking:
In dit programma heb je de volgende functionaliteiten:
•	Gebruiker aanmaken
•	Gebruiker verwijderen
•	Gebruiker bekijken
•	Gebruiker aanpassen
•	Programma sluiten


1: Gebruiker aanmaken.
Deze functie gebruik je als je een gebruiker wilt aanmaken. Als je deze functie wilt gebruiken dan type je 1 in de main menu, daarna vraagt het programma je steeds om gegevens.

Bij elke vraag vul je gegevens in en klik je op enter totdat je jouw naam, email, adress, telefoonnummer en leeftijd hebt ingevult, daarna kan je terug gaan naar de main menu door op een willekeurige knop te klikken. 

 
Elke keer dat je de volgende gegevens moet invullen wordt de console leeg gemaakt en stelt het een nieuwe vraag die je kan beantwoorden door een Console.ReadLine, daarna wordt de informatie opgeslagen. 
Voor email en leeftijd gebruiken ze een while-loop om de vraag te blijven stellen totdat je het invult in het goede formaat. 
Nadat je alles hebt ingevult worden de gegevens gebruikt om een nieuwe user te maken en die wordt opgeslagen in de user database.




2: Gebruiker verwijderen.
Deze functie gebruik je als je een gebruiker wilt verwijderen. Als je deze functie wilt gebruiken dan type je 2 in de main menu, daarna vraagt het programma je om een ID in te vullen om te verwijderen, of je kan CANCEL typen om terug te gaan.
 
De while-loop wordt gebruikt om ervoor te zorgen dat je alleen CANCEL of een nummer kan invoeren. TryParse wordt gebruikt om te checken of je een nummer invoert of niet. 
De if-statement checkt of de ID die je invult bestaat, zo niet dan vraagt het programma opnieuw aan je om een ID in te vullen. 
Als je een ID invult die bestaat dan wordt de user met die ID verwijdert en dan kan je terug gaan naar de main menu.




3: Gebruiker bekijken.
Deze functie gebruik je wanneer je de list van gebruikers wilt bekijken. Als je deze functie wilt gebruiken dan type je 3 in de main menu, daarna laat het programma alle users zien.
 
De if-statements checken of de user list wel een user erin heeft, zo niet dan print het dat er geen users zijn, zowel dan checkt het of er 1 user of meerdere zijn en dan laat het de hoeveelheid users zien en de informatie van de users.




4: Gebruiker aanpassen.
Deze functie gebruik je als je een gebruiker wilt aanpassen. Als je deze functie wilt gebruiken dan type je 4 in de main menu. 
Het programma vraagt je dan om de ID van de user die je wilt aanpassen en daarna vraagt het om jouw naam, email, adress, telefoonnummer en leeftijd in te vullen, hetzelfde als je een nieuwe gebruiker aanmaakt.

  
Als eerst checkt het programma of de ingevullde ID wel echt bestaat net zoals bij het verwijderen van een gebruiker. 
De TryParse zorgt ervoor dat je alleen een nummer kan invoeren en de while-loop zorgt ervoor dat je opnieuw een ID kan invullen. 
Daarna verwijdert het de user die de ingevulde ID heeft en laat het programma je een user aanmaken met nieuwe gegevens net zoals het maken van een nieuwe user.
De gegevens die je invoert zijn naam, email, adress, telefoonnummer en leeftijd. De user krijgt dan die informatie en daarna kan je weer terug naar de main menu.




5: Programma sluiten.
Deze functie gebruik je als je het programma wilt sluiten. Als je deze functie wilt gebruiken dan type je 5 in de main menu, daarna vraagt het programma je steeds om gegevens.

 
Het programma wordt beëindigd door Enviroment.Exit(1), dat is het enige wat Exit program doet.
