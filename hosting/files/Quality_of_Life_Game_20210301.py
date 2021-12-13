#  
#  DB Script Tool
#  Python - 2021-03-01 14:48:38
#  
#  MODEL CLASSES FOR Quality_of_Life_Game DATABASE
#



# Player.py -------------------------------------
from datetime import datetime, date

# 
# Python - Model Class - Quality_of_Life_Game.Player
# 2021-03-01 13:42:44
#
class Player(Object):

    #
    # Constructor
    #
    # Example: 
    # myPlayer = Player( val1, val2,.. )
    #
    def __init__(self, id = None, redrace = None, yellowrace = None, purplerace = None, greenrace = None, orangerace = None, bluerace = None):
        self.__id = id
        self.__redrace = redrace
        self.__yellowrace = yellowrace
        self.__purplerace = purplerace
        self.__greenrace = greenrace
        self.__orangerace = orangerace
        self.__bluerace = bluerace


    #
    # Properties
    #

    @property
    def id(self):
        return self.__id

    @id.setter
    def id(self, id):
        self.__id = id

    @property
    def redrace(self):
        return self.__redrace

    @redrace.setter
    def redrace(self, redrace):
        self.__redrace = redrace

    @property
    def yellowrace(self):
        return self.__yellowrace

    @yellowrace.setter
    def yellowrace(self, yellowrace):
        self.__yellowrace = yellowrace

    @property
    def purplerace(self):
        return self.__purplerace

    @purplerace.setter
    def purplerace(self, purplerace):
        self.__purplerace = purplerace

    @property
    def greenrace(self):
        return self.__greenrace

    @greenrace.setter
    def greenrace(self, greenrace):
        self.__greenrace = greenrace

    @property
    def orangerace(self):
        return self.__orangerace

    @orangerace.setter
    def orangerace(self, orangerace):
        self.__orangerace = orangerace

    @property
    def bluerace(self):
        return self.__bluerace

    @bluerace.setter
    def bluerace(self, bluerace):
        self.__bluerace = bluerace



    #
    # Methods
    #

    def __str__ (self):
        return ""



# Nonplayer.py -------------------------------------
from datetime import datetime, date

# 
# Python - Model Class - Quality_of_Life_Game.Nonplayer
# 2021-03-01 13:56:27
#
class Nonplayer(Object):

    #
    # Constructor
    #
    # Example: 
    # myNonplayer = Nonplayer( val1, val2,.. )
    #
    def __init__(self, _id = None, rexoedipus = None, lightbluerace = None, pinkrace = None, brownrace = None, fred = None, edtdoide = None, genecrispy = None, hysteriaptrance = None, officermodusponens = None, officermodustollens = None, sifidious = None, imhotepbizarros = None, barryukolmar = None):
        self.___id = _id
        self.__rexoedipus = rexoedipus
        self.__lightbluerace = lightbluerace
        self.__pinkrace = pinkrace
        self.__brownrace = brownrace
        self.__fred = fred
        self.__edtdoide = edtdoide
        self.__genecrispy = genecrispy
        self.__hysteriaptrance = hysteriaptrance
        self.__officermodusponens = officermodusponens
        self.__officermodustollens = officermodustollens
        self.__sifidious = sifidious
        self.__imhotepbizarros = imhotepbizarros
        self.__barryukolmar = barryukolmar


    #
    # Properties
    #

    @property
    def _id(self):
        return self.___id

    @_id.setter
    def _id(self, _id):
        self.___id = _id

    @property
    def rexoedipus(self):
        return self.__rexoedipus

    @rexoedipus.setter
    def rexoedipus(self, rexoedipus):
        self.__rexoedipus = rexoedipus

    @property
    def lightbluerace(self):
        return self.__lightbluerace

    @lightbluerace.setter
    def lightbluerace(self, lightbluerace):
        self.__lightbluerace = lightbluerace

    @property
    def pinkrace(self):
        return self.__pinkrace

    @pinkrace.setter
    def pinkrace(self, pinkrace):
        self.__pinkrace = pinkrace

    @property
    def brownrace(self):
        return self.__brownrace

    @brownrace.setter
    def brownrace(self, brownrace):
        self.__brownrace = brownrace

    @property
    def fred(self):
        return self.__fred

    @fred.setter
    def fred(self, fred):
        self.__fred = fred

    @property
    def edtdoide(self):
        return self.__edtdoide

    @edtdoide.setter
    def edtdoide(self, edtdoide):
        self.__edtdoide = edtdoide

    @property
    def genecrispy(self):
        return self.__genecrispy

    @genecrispy.setter
    def genecrispy(self, genecrispy):
        self.__genecrispy = genecrispy

    @property
    def hysteriaptrance(self):
        return self.__hysteriaptrance

    @hysteriaptrance.setter
    def hysteriaptrance(self, hysteriaptrance):
        self.__hysteriaptrance = hysteriaptrance

    @property
    def officermodusponens(self):
        return self.__officermodusponens

    @officermodusponens.setter
    def officermodusponens(self, officermodusponens):
        self.__officermodusponens = officermodusponens

    @property
    def officermodustollens(self):
        return self.__officermodustollens

    @officermodustollens.setter
    def officermodustollens(self, officermodustollens):
        self.__officermodustollens = officermodustollens

    @property
    def sifidious(self):
        return self.__sifidious

    @sifidious.setter
    def sifidious(self, sifidious):
        self.__sifidious = sifidious

    @property
    def imhotepbizarros(self):
        return self.__imhotepbizarros

    @imhotepbizarros.setter
    def imhotepbizarros(self, imhotepbizarros):
        self.__imhotepbizarros = imhotepbizarros

    @property
    def barryukolmar(self):
        return self.__barryukolmar

    @barryukolmar.setter
    def barryukolmar(self, barryukolmar):
        self.__barryukolmar = barryukolmar



    #
    # Methods
    #

    def __str__ (self):
        return ""



# Neighborhoods.py -------------------------------------
from datetime import datetime, date

# 
# Python - Model Class - Quality_of_Life_Game.Neighborhoods
# 2021-03-01 14:19:40
#
class Neighborhoods(Object):

    #
    # Constructor
    #
    # Example: 
    # myNeighborhoods = Neighborhoods( val1, val2,.. )
    #
    def __init__(self, _id = None, redneighborhood = None, yellowneighborhood = None, purpleneigborhood = None, greenneighborhood = None, orangeneighborhood = None, blueneighborhood = None):
        self.___id = _id
        self.__redneighborhood = redneighborhood
        self.__yellowneighborhood = yellowneighborhood
        self.__purpleneigborhood = purpleneigborhood
        self.__greenneighborhood = greenneighborhood
        self.__orangeneighborhood = orangeneighborhood
        self.__blueneighborhood = blueneighborhood


    #
    # Properties
    #

    @property
    def _id(self):
        return self.___id

    @_id.setter
    def _id(self, _id):
        self.___id = _id

    @property
    def redneighborhood(self):
        return self.__redneighborhood

    @redneighborhood.setter
    def redneighborhood(self, redneighborhood):
        self.__redneighborhood = redneighborhood

    @property
    def yellowneighborhood(self):
        return self.__yellowneighborhood

    @yellowneighborhood.setter
    def yellowneighborhood(self, yellowneighborhood):
        self.__yellowneighborhood = yellowneighborhood

    @property
    def purpleneigborhood(self):
        return self.__purpleneigborhood

    @purpleneigborhood.setter
    def purpleneigborhood(self, purpleneigborhood):
        self.__purpleneigborhood = purpleneigborhood

    @property
    def greenneighborhood(self):
        return self.__greenneighborhood

    @greenneighborhood.setter
    def greenneighborhood(self, greenneighborhood):
        self.__greenneighborhood = greenneighborhood

    @property
    def orangeneighborhood(self):
        return self.__orangeneighborhood

    @orangeneighborhood.setter
    def orangeneighborhood(self, orangeneighborhood):
        self.__orangeneighborhood = orangeneighborhood

    @property
    def blueneighborhood(self):
        return self.__blueneighborhood

    @blueneighborhood.setter
    def blueneighborhood(self, blueneighborhood):
        self.__blueneighborhood = blueneighborhood



    #
    # Methods
    #

    def __str__ (self):
        return ""



# Social_Bubbles.py -------------------------------------
from datetime import datetime, date

# 
# Python - Model Class - Quality_of_Life_Game.Social_Bubbles
# 
#
class Social_Bubbles(Object):

    #
    # Constructor
    #
    # Example: 
    # mySocial_Bubbles = Social_Bubbles( val1, val2,.. )
    #
    def __init__(self, _id = None, socioeconomicstatus = None, household = None, race = None, transportation = None, epidemiologicalfactors = None, healthfactors = None):
        self.___id = _id
        self.__socioeconomicstatus = socioeconomicstatus
        self.__household = household
        self.__race = race
        self.__transportation = transportation
        self.__epidemiologicalfactors = epidemiologicalfactors
        self.__healthfactors = healthfactors


    #
    # Properties
    #

    @property
    def _id(self):
        return self.___id

    @_id.setter
    def _id(self, _id):
        self.___id = _id

    @property
    def socioeconomicstatus(self):
        return self.__socioeconomicstatus

    @socioeconomicstatus.setter
    def socioeconomicstatus(self, socioeconomicstatus):
        self.__socioeconomicstatus = socioeconomicstatus

    @property
    def household(self):
        return self.__household

    @household.setter
    def household(self, household):
        self.__household = household

    @property
    def race(self):
        return self.__race

    @race.setter
    def race(self, race):
        self.__race = race

    @property
    def transportation(self):
        return self.__transportation

    @transportation.setter
    def transportation(self, transportation):
        self.__transportation = transportation

    @property
    def epidemiologicalfactors(self):
        return self.__epidemiologicalfactors

    @epidemiologicalfactors.setter
    def epidemiologicalfactors(self, epidemiologicalfactors):
        self.__epidemiologicalfactors = epidemiologicalfactors

    @property
    def healthfactors(self):
        return self.__healthfactors

    @healthfactors.setter
    def healthfactors(self, healthfactors):
        self.__healthfactors = healthfactors



    #
    # Methods
    #

    def __str__ (self):
        return ""



# Health_Factors.py -------------------------------------
from datetime import datetime, date

# 
# Python - Model Class - Quality_of_Life_Game.Health_Factors
# 
#
class Health_Factors(Object):

    #
    # Constructor
    #
    # Example: 
    # myHealth_Factors = Health_Factors( val1, val2,.. )
    #
    def __init__(self, _id = None, unexpectedpregnancy = None, measles = None, mumps = None, rubella = None, pneumonia = None, diabetes = None):
        self.___id = _id
        self.__unexpectedpregnancy = unexpectedpregnancy
        self.__measles = measles
        self.__mumps = mumps
        self.__rubella = rubella
        self.__pneumonia = pneumonia
        self.__diabetes = diabetes


    #
    # Properties
    #

    @property
    def _id(self):
        return self.___id

    @_id.setter
    def _id(self, _id):
        self.___id = _id

    @property
    def unexpectedpregnancy(self):
        return self.__unexpectedpregnancy

    @unexpectedpregnancy.setter
    def unexpectedpregnancy(self, unexpectedpregnancy):
        self.__unexpectedpregnancy = unexpectedpregnancy

    @property
    def measles(self):
        return self.__measles

    @measles.setter
    def measles(self, measles):
        self.__measles = measles

    @property
    def mumps(self):
        return self.__mumps

    @mumps.setter
    def mumps(self, mumps):
        self.__mumps = mumps

    @property
    def rubella(self):
        return self.__rubella

    @rubella.setter
    def rubella(self, rubella):
        self.__rubella = rubella

    @property
    def pneumonia(self):
        return self.__pneumonia

    @pneumonia.setter
    def pneumonia(self, pneumonia):
        self.__pneumonia = pneumonia

    @property
    def diabetes(self):
        return self.__diabetes

    @diabetes.setter
    def diabetes(self, diabetes):
        self.__diabetes = diabetes



    #
    # Methods
    #

    def __str__ (self):
        return ""



# Socioeconomic_Status.py -------------------------------------
from datetime import datetime, date

# 
# Python - Model Class - Quality_of_Life_Game.Socioeconomic_Status
# 2021-03-01 14:36:28
#
class Socioeconomic_Status(Object):

    #
    # Constructor
    #
    # Example: 
    # mySocioeconomic_Status = Socioeconomic_Status( val1, val2,.. )
    #
    def __init__(self, _id = None, bankruptcy = None, unemployment = None, homeinvasion = None, incomedrop = None, incomeloss = None, eviction = None):
        self.___id = _id
        self.__bankruptcy = bankruptcy
        self.__unemployment = unemployment
        self.__homeinvasion = homeinvasion
        self.__incomedrop = incomedrop
        self.__incomeloss = incomeloss
        self.__eviction = eviction


    #
    # Properties
    #

    @property
    def _id(self):
        return self.___id

    @_id.setter
    def _id(self, _id):
        self.___id = _id

    @property
    def bankruptcy(self):
        return self.__bankruptcy

    @bankruptcy.setter
    def bankruptcy(self, bankruptcy):
        self.__bankruptcy = bankruptcy

    @property
    def unemployment(self):
        return self.__unemployment

    @unemployment.setter
    def unemployment(self, unemployment):
        self.__unemployment = unemployment

    @property
    def homeinvasion(self):
        return self.__homeinvasion

    @homeinvasion.setter
    def homeinvasion(self, homeinvasion):
        self.__homeinvasion = homeinvasion

    @property
    def incomedrop(self):
        return self.__incomedrop

    @incomedrop.setter
    def incomedrop(self, incomedrop):
        self.__incomedrop = incomedrop

    @property
    def incomeloss(self):
        return self.__incomeloss

    @incomeloss.setter
    def incomeloss(self, incomeloss):
        self.__incomeloss = incomeloss

    @property
    def eviction(self):
        return self.__eviction

    @eviction.setter
    def eviction(self, eviction):
        self.__eviction = eviction



    #
    # Methods
    #

    def __str__ (self):
        return ""