/* 
*  DB Script Tool
*  Kotlin - 2021-05-17 16:26:24
*  
*  MODEL CLASSES FOR Quality_of_Life_Game DATABASE
*/ 



/* Player.kt -------------------------------------*/
package com.package.Quality_of_Life_Game.model 

//import java.util.*
//import java.sql.*
//import java.text.*

/* 
*  Kotlin - Model Class - Quality_of_Life_Game.Player
*  2021-03-01 13:42:44
*/ 
data class Player (
    var id: Int,
    var redrace: Int?,
    var yellowrace: Int?,
    var purplerace: Int?,
    var greenrace: Int?,
    var orangerace: Int?,
    var bluerace: Int?,
    var susceptibleindividual: Int?,
    var exposedindividual: Int?,
    var infectedindividual: Int?,
    var removedindividual: Int?,
    var intoxicateddriver: Int?,
    var shearstress: Double?
)


/* Nonplayer.kt -------------------------------------*/
package com.package.Quality_of_Life_Game.model 

//import java.util.*
//import java.sql.*
//import java.text.*

/* 
*  Kotlin - Model Class - Quality_of_Life_Game.Nonplayer
*  2021-03-01 13:56:27
*/ 
data class Nonplayer (
    var _id: Int,
    var rexoedipus: Int?,
    var lightbluerace: Int?,
    var pinkrace: Int?,
    var brownrace: Int?,
    var fred: Int?,
    var edtdoide: Int?,
    var genecrispy: Int?,
    var hysteriaptrance: Int?,
    var officermodusponens: Int?,
    var officermodustollens: Int?,
    var sifidious: Int?,
    var imhotepbizarros: Int?,
    var barryukolmar: Int?,
    var ableacage: Int?
)


/* Neighborhoods.kt -------------------------------------*/
package com.package.Quality_of_Life_Game.model 

//import java.util.*
//import java.sql.*
//import java.text.*

/* 
*  Kotlin - Model Class - Quality_of_Life_Game.Neighborhoods
*  2021-03-01 14:19:40
*/ 
data class Neighborhoods (
    var _id: Int,
    var redneighborhood: Int?,
    var yellowneighborhood: Int?,
    var purpleneigborhood: Int?,
    var greenneighborhood: Int?,
    var orangeneighborhood: Int?,
    var blueneighborhood: Int?
)


/* Social_Bubbles.kt -------------------------------------*/
package com.package.Quality_of_Life_Game.model 

//import java.util.*
//import java.sql.*
//import java.text.*

/* 
*  Kotlin - Model Class - Quality_of_Life_Game.Social_Bubbles
*  
*/ 
data class Social_Bubbles (
    var _id: Int,
    var socioeconomicstatus: Double?,
    var household: Boolean?,
    var race: Boolean?,
    var transportation: java.sql.Time?,
    var epidemiologicalfactors: Double?,
    var healthfactors: Boolean?,
    var needs: Boolean?,
    var lifeshocks: Int?,
    var viciouscyclesofpoverty: Int?,
    var lossofincome: Double?,
    var dropinincome: Double?
)


/* Health_Factors.kt -------------------------------------*/
package com.package.Quality_of_Life_Game.model 

//import java.util.*
//import java.sql.*
//import java.text.*

/* 
*  Kotlin - Model Class - Quality_of_Life_Game.Health_Factors
*  
*/ 
data class Health_Factors (
    var _id: Int,
    var unexpectedpregnancy: Int?,
    var measles: Int?,
    var mumps: Int?,
    var rubella: Int?,
    var pneumonia: Int?,
    var diabetes: Int?
)


/* Socioeconomic_Status.kt -------------------------------------*/
package com.package.Quality_of_Life_Game.model 

//import java.util.*
//import java.sql.*
//import java.text.*

/* 
*  Kotlin - Model Class - Quality_of_Life_Game.Socioeconomic_Status
*  2021-03-01 14:36:28
*/ 
data class Socioeconomic_Status (
    var _id: Int,
    var bankruptcy: Int?,
    var unemployment: Int?,
    var homeinvasion: Int?,
    var incomedrop: Int?,
    var incomeloss: Int?,
    var eviction: Int?
)


/* Random_Glucose_Levels.kt -------------------------------------*/
package com.package.Quality_of_Life_Game.model 

//import java.util.*
//import java.sql.*
//import java.text.*

/* 
*  Kotlin - Model Class - Quality_of_Life_Game.Random_Glucose_Levels
*  2021-03-02 08:29:01
*/ 
data class Random_Glucose_Levels (
    var _id: Int,
    var kentuckyfriedchicken: Int?,
    var ramenfury: Int?,
    var diabetesindividuals: Int?,
    var pizza: Int?,
    var foodDrink: Double?,
    var vegetables: Double?,
    var fruits: Double?,
    var dairy: Double?,
    var meat: Double?,
    var fish: Double?,
    var grains: Double?
)


/* COSINE_MUD_Box.kt -------------------------------------*/
package com.package.Quality_of_Life_Game.model 

//import java.util.*
//import java.sql.*
//import java.text.*

/* 
*  Kotlin - Model Class - Quality_of_Life_Game.COSINE_MUD_Box
*  2021-03-07 00:52:35
*/ 
data class COSINE_MUD_Box (
    var _id: Int,
    var cosinegameforum: Int?,
    var publicnuisancecitygame: Int?,
    var qualityoflifegames: Int?,
    var socialbubbles: Int?,
    var deviceType: Double?,
    var unityengine: Int?
)


/* Pentose_Phosphate_Freeway.kt -------------------------------------*/
package com.package.Quality_of_Life_Game.model 

//import java.util.*
//import java.sql.*
//import java.text.*

/* 
*  Kotlin - Model Class - Quality_of_Life_Game.Pentose_Phosphate_Freeway
*  The highway of the Kingdom of TRANCE
*/ 
data class Pentose_Phosphate_Freeway (
    var _id: Int,
    var phagehexamernanocar2020: Int?,
    var keggcolorpathway: Boolean?,
    var intensity: Int?
)


/* Epidemic_Seasons.kt -------------------------------------*/
package com.package.Quality_of_Life_Game.model 

//import java.util.*
//import java.sql.*
//import java.text.*

/* 
*  Kotlin - Model Class - Quality_of_Life_Game.Epidemic_Seasons
*  2021-04-17 07:51:27
*/ 
data class Epidemic_Seasons (
    var _id: Int,
    var tacitfindings: Int?,
    var trancecircles: Int?
)