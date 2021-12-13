/* 
*  DB Script Tool
*  C# Entity Framework (C#) - 2021-03-01 14:48:58
*  
*  MODEL CLASSES FOR Quality_of_Life_Game DATABASE
*/



/* Player.cs -------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace Quality_of_Life_Game.Models 
{

    /// <summary>
    ///  C# - Model Class - Quality_of_Life_Game.Player
    ///  2021-03-01 13:42:44
    /// </summary>
    //[Table("Player")]
    public class Player {

       /// <summary>
       ///  Constructor
       /// </summary>
       /// <example>
       ///   Example
       ///   <code>
       ///   Player myPlayer = new Player();
       ///   </code>
       /// </example>
        public Player() {
            //--
            this.PlayerList = new HashSet<Player>();
        }

       /// <summary>
       ///  Constructor
       /// </summary>
       /// <example>
       ///   Example
       ///   <code>
       ///   Player myPlayer = new Player( val1, val2,.. );
       ///   </code>
       /// </example>
        public Player(int id, long redrace, long yellowrace, long purplerace, long greenrace, long orangerace, long bluerace) {
            this.Id = id;
            this.Redrace = redrace;
            this.Yellowrace = yellowrace;
            this.Purplerace = purplerace;
            this.Greenrace = greenrace;
            this.Orangerace = orangerace;
            this.Bluerace = bluerace;
            this.PlayerList = new HashSet<Player>();
        }


        /**
        * Properties
        */

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public long Redrace { get; set; }

        public long Yellowrace { get; set; }

        public long Purplerace { get; set; }

        public long Greenrace { get; set; }

        public long Orangerace { get; set; }

        public long Bluerace { get; set; }



        public virtual ICollection<Player> PlayerList { get; set; }



        /**
        * Methods
        */

        public override string ToString() {
            return "";
        }

    }

}



/* Nonplayer.cs -------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace Quality_of_Life_Game.Models 
{

    /// <summary>
    ///  C# - Model Class - Quality_of_Life_Game.Nonplayer
    ///  2021-03-01 13:56:27
    /// </summary>
    //[Table("Nonplayer")]
    public class Nonplayer {

       /// <summary>
       ///  Constructor
       /// </summary>
       /// <example>
       ///   Example
       ///   <code>
       ///   Nonplayer myNonplayer = new Nonplayer();
       ///   </code>
       /// </example>
        public Nonplayer() {
            //--
        }

       /// <summary>
       ///  Constructor
       /// </summary>
       /// <example>
       ///   Example
       ///   <code>
       ///   Nonplayer myNonplayer = new Nonplayer( val1, val2,.. );
       ///   </code>
       /// </example>
        public Nonplayer(int _id, int rexoedipus, int lightbluerace, int pinkrace, int brownrace, int fred, int edtdoide, int genecrispy, int hysteriaptrance, int officermodusponens, int officermodustollens, int sifidious, int imhotepbizarros, int barryukolmar) {
            this._id = _id;
            this.Rexoedipus = rexoedipus;
            this.Lightbluerace = lightbluerace;
            this.Pinkrace = pinkrace;
            this.Brownrace = brownrace;
            this.Fred = fred;
            this.Edtdoide = edtdoide;
            this.Genecrispy = genecrispy;
            this.Hysteriaptrance = hysteriaptrance;
            this.Officermodusponens = officermodusponens;
            this.Officermodustollens = officermodustollens;
            this.Sifidious = sifidious;
            this.Imhotepbizarros = imhotepbizarros;
            this.Barryukolmar = barryukolmar;
        }


        /**
        * Properties
        */

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int _id { get; set; }

        public int Rexoedipus { get; set; }

        public int Lightbluerace { get; set; }

        public int Pinkrace { get; set; }

        public int Brownrace { get; set; }

        public int Fred { get; set; }

        public int Edtdoide { get; set; }

        public int Genecrispy { get; set; }

        public int Hysteriaptrance { get; set; }

        public int Officermodusponens { get; set; }

        public int Officermodustollens { get; set; }

        public int Sifidious { get; set; }

        public int Imhotepbizarros { get; set; }

        public int Barryukolmar { get; set; }





        /**
        * Methods
        */

        public override string ToString() {
            return "";
        }

    }

}



/* Neighborhoods.cs -------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace Quality_of_Life_Game.Models 
{

    /// <summary>
    ///  C# - Model Class - Quality_of_Life_Game.Neighborhoods
    ///  2021-03-01 14:19:40
    /// </summary>
    //[Table("Neighborhoods")]
    public class Neighborhoods {

       /// <summary>
       ///  Constructor
       /// </summary>
       /// <example>
       ///   Example
       ///   <code>
       ///   Neighborhoods myNeighborhoods = new Neighborhoods();
       ///   </code>
       /// </example>
        public Neighborhoods() {
            //--
        }

       /// <summary>
       ///  Constructor
       /// </summary>
       /// <example>
       ///   Example
       ///   <code>
       ///   Neighborhoods myNeighborhoods = new Neighborhoods( val1, val2,.. );
       ///   </code>
       /// </example>
        public Neighborhoods(int _id, int redneighborhood, int yellowneighborhood, int purpleneigborhood, int greenneighborhood, int orangeneighborhood, int blueneighborhood) {
            this._id = _id;
            this.Redneighborhood = redneighborhood;
            this.Yellowneighborhood = yellowneighborhood;
            this.Purpleneigborhood = purpleneigborhood;
            this.Greenneighborhood = greenneighborhood;
            this.Orangeneighborhood = orangeneighborhood;
            this.Blueneighborhood = blueneighborhood;
        }


        /**
        * Properties
        */

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int _id { get; set; }

        //[ForeignKey("Player")]
        public int Redneighborhood { get; set; }
        public virtual Player Player { get; set; }

        //[ForeignKey("Player")]
        public int Yellowneighborhood { get; set; }
        public virtual Player Player { get; set; }

        public int Purpleneigborhood { get; set; }

        public int Greenneighborhood { get; set; }

        public int Orangeneighborhood { get; set; }

        public int Blueneighborhood { get; set; }





        /**
        * Methods
        */

        public override string ToString() {
            return "";
        }

    }

}



/* Social_Bubbles.cs -------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace Quality_of_Life_Game.Models 
{

    /// <summary>
    ///  C# - Model Class - Quality_of_Life_Game.Social_Bubbles
    ///  
    /// </summary>
    //[Table("Social_Bubbles")]
    public class Social_Bubbles {

       /// <summary>
       ///  Constructor
       /// </summary>
       /// <example>
       ///   Example
       ///   <code>
       ///   Social_Bubbles mySocial_Bubbles = new Social_Bubbles();
       ///   </code>
       /// </example>
        public Social_Bubbles() {
            //--
        }

       /// <summary>
       ///  Constructor
       /// </summary>
       /// <example>
       ///   Example
       ///   <code>
       ///   Social_Bubbles mySocial_Bubbles = new Social_Bubbles( val1, val2,.. );
       ///   </code>
       /// </example>
        public Social_Bubbles(int _id, int socioeconomicstatus, int household, int race, int transportation, int epidemiologicalfactors, int healthfactors) {
            this._id = _id;
            this.Socioeconomicstatus = socioeconomicstatus;
            this.Household = household;
            this.Race = race;
            this.Transportation = transportation;
            this.Epidemiologicalfactors = epidemiologicalfactors;
            this.Healthfactors = healthfactors;
        }


        /**
        * Properties
        */

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int _id { get; set; }

        public int Socioeconomicstatus { get; set; }

        public int Household { get; set; }

        public int Race { get; set; }

        public int Transportation { get; set; }

        public int Epidemiologicalfactors { get; set; }

        public int Healthfactors { get; set; }





        /**
        * Methods
        */

        public override string ToString() {
            return "";
        }

    }

}



/* Health_Factors.cs -------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace Quality_of_Life_Game.Models 
{

    /// <summary>
    ///  C# - Model Class - Quality_of_Life_Game.Health_Factors
    ///  
    /// </summary>
    //[Table("Health_Factors")]
    public class Health_Factors {

       /// <summary>
       ///  Constructor
       /// </summary>
       /// <example>
       ///   Example
       ///   <code>
       ///   Health_Factors myHealth_Factors = new Health_Factors();
       ///   </code>
       /// </example>
        public Health_Factors() {
            //--
        }

       /// <summary>
       ///  Constructor
       /// </summary>
       /// <example>
       ///   Example
       ///   <code>
       ///   Health_Factors myHealth_Factors = new Health_Factors( val1, val2,.. );
       ///   </code>
       /// </example>
        public Health_Factors(int _id, int unexpectedpregnancy, int measles, int mumps, int rubella, int pneumonia, int diabetes) {
            this._id = _id;
            this.Unexpectedpregnancy = unexpectedpregnancy;
            this.Measles = measles;
            this.Mumps = mumps;
            this.Rubella = rubella;
            this.Pneumonia = pneumonia;
            this.Diabetes = diabetes;
        }


        /**
        * Properties
        */

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int _id { get; set; }

        public int Unexpectedpregnancy { get; set; }

        public int Measles { get; set; }

        public int Mumps { get; set; }

        public int Rubella { get; set; }

        public int Pneumonia { get; set; }

        public int Diabetes { get; set; }





        /**
        * Methods
        */

        public override string ToString() {
            return "";
        }

    }

}



/* Socioeconomic_Status.cs -------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace Quality_of_Life_Game.Models 
{

    /// <summary>
    ///  C# - Model Class - Quality_of_Life_Game.Socioeconomic_Status
    ///  2021-03-01 14:36:28
    /// </summary>
    //[Table("Socioeconomic_Status")]
    public class Socioeconomic_Status {

       /// <summary>
       ///  Constructor
       /// </summary>
       /// <example>
       ///   Example
       ///   <code>
       ///   Socioeconomic_Status mySocioeconomic_Status = new Socioeconomic_Status();
       ///   </code>
       /// </example>
        public Socioeconomic_Status() {
            //--
        }

       /// <summary>
       ///  Constructor
       /// </summary>
       /// <example>
       ///   Example
       ///   <code>
       ///   Socioeconomic_Status mySocioeconomic_Status = new Socioeconomic_Status( val1, val2,.. );
       ///   </code>
       /// </example>
        public Socioeconomic_Status(int _id, int bankruptcy, int unemployment, int homeinvasion, int incomedrop, int incomeloss, int eviction) {
            this._id = _id;
            this.Bankruptcy = bankruptcy;
            this.Unemployment = unemployment;
            this.Homeinvasion = homeinvasion;
            this.Incomedrop = incomedrop;
            this.Incomeloss = incomeloss;
            this.Eviction = eviction;
        }


        /**
        * Properties
        */

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int _id { get; set; }

        public int Bankruptcy { get; set; }

        public int Unemployment { get; set; }

        public int Homeinvasion { get; set; }

        public int Incomedrop { get; set; }

        public int Incomeloss { get; set; }

        public int Eviction { get; set; }





        /**
        * Methods
        */

        public override string ToString() {
            return "";
        }

    }

}