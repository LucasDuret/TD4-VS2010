# PRIVE - Réservistes #

## /api/reservistes/ ##

### `GET` /api/reservistes/ ###

_Lister les réservistes_

#### Response ####

[]:

  * type: array of objects (Reserviste)

[][nom]:

  * type: string

[][prenom]:

  * type: string

[][email]:

  * type: string

[][grade]:

  * type: string

[][id]:

  * type: integer

[][dateNaissance]:

  * type: DateTime

[][numTelephone]:

  * type: string

[][adressePostale]:

  * type: string

[][commentaire]:

  * type: string

[][competences][]:

  * type: array of objects (Competence)

[][competences][][id]:

  * type: integer

[][competences][][sousAxe]:

  * type: string

[][competences][][axe]:

  * type: string

[][competences][][description]:

  * type: string

[][competences][][niveau]:

  * type: integer


### `POST` /api/reservistes/ ###

_Ajout d'un réserviste_

#### Filters ####

login:

  * Requirement: [a-z]+
  * Description: Login de l'utilisateur
  * Default: 

#### Parameters ####

nom:

  * type: string
  * required: true

prenom:

  * type: string
  * required: true

email:

  * type: string
  * required: true

grade:

  * type: string
  * required: true

dateNaissance:

  * type: datetime
  * required: true

numTelephone:

  * type: string
  * required: true

adressePostale:

  * type: string
  * required: false

commentaire:

  * type: string
  * required: false

competences[]:

  * type: array of objects (CompetenceType)
  * required: true

competences[][sousAxe]:

  * type: string
  * required: true

competences[][axe]:

  * type: string
  * required: true

competences[][description]:

  * type: string
  * required: false

competences[][niveau]:

  * type: integer
  * required: true
