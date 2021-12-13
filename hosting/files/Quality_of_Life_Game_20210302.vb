'--  
'-  DB Script Tool
'-  VB.Net (Visual Basic .Net) - 2021-03-02 11:31:29
'-  
'-  MODEL CLASSES FOR Quality_of_Life_Game DATABASE
'--



' Player.vb -------------------------------------
Imports System

Namespace Quality_of_Life_Game.model 

' <summary>
' VB.Net - Model Class - Quality_of_Life_Game.Player
' 2021-03-01 13:42:44
' </summary>
Public Class Player 

    '--
    '- Constructor
    '- 
    '- Example: 
    '- Dim myPlayer As New Player 
    '--
    Public Sub New()
        '--
    End Sub

    '--
    '- Constructor
    '- 
    '- Example: 
    '- Dim myPlayer As New Player( val1, val2,.. )
    '--
    Public Sub New(ByVal id As Integer, ByVal redrace As Long, ByVal yellowrace As Long, ByVal purplerace As Long, ByVal greenrace As Long, ByVal orangerace As Long, ByVal bluerace As Long)
        Me.Id = id
        Me.Redrace = redrace
        Me.Yellowrace = yellowrace
        Me.Purplerace = purplerace
        Me.Greenrace = greenrace
        Me.Orangerace = orangerace
        Me.Bluerace = bluerace
    End Sub


    '--
    '- Properties
    '--

    Public Property Id As Integer

    Public Property Redrace As Long

    Public Property Yellowrace As Long

    Public Property Purplerace As Long

    Public Property Greenrace As Long

    Public Property Orangerace As Long

    Public Property Bluerace As Long


    '--
    '- Methods
    '--

    Public Overrides Function ToString() As String
        Return ""
    End Function

End Class

End Namespace



' Nonplayer.vb -------------------------------------
Imports System

Namespace Quality_of_Life_Game.model 

' <summary>
' VB.Net - Model Class - Quality_of_Life_Game.Nonplayer
' 2021-03-01 13:56:27
' </summary>
Public Class Nonplayer 

    '--
    '- Constructor
    '- 
    '- Example: 
    '- Dim myNonplayer As New Nonplayer 
    '--
    Public Sub New()
        '--
    End Sub

    '--
    '- Constructor
    '- 
    '- Example: 
    '- Dim myNonplayer As New Nonplayer( val1, val2,.. )
    '--
    Public Sub New(ByVal _id As Integer, ByVal rexoedipus As Integer, ByVal lightbluerace As Integer, ByVal pinkrace As Integer, ByVal brownrace As Integer, ByVal fred As Integer, ByVal edtdoide As Integer, ByVal genecrispy As Integer, ByVal hysteriaptrance As Integer, ByVal officermodusponens As Integer, ByVal officermodustollens As Integer, ByVal sifidious As Integer, ByVal imhotepbizarros As Integer, ByVal barryukolmar As Integer)
        Me._id = _id
        Me.Rexoedipus = rexoedipus
        Me.Lightbluerace = lightbluerace
        Me.Pinkrace = pinkrace
        Me.Brownrace = brownrace
        Me.Fred = fred
        Me.Edtdoide = edtdoide
        Me.Genecrispy = genecrispy
        Me.Hysteriaptrance = hysteriaptrance
        Me.Officermodusponens = officermodusponens
        Me.Officermodustollens = officermodustollens
        Me.Sifidious = sifidious
        Me.Imhotepbizarros = imhotepbizarros
        Me.Barryukolmar = barryukolmar
    End Sub


    '--
    '- Properties
    '--

    Public Property _id As Integer

    Public Property Rexoedipus As Integer

    Public Property Lightbluerace As Integer

    Public Property Pinkrace As Integer

    Public Property Brownrace As Integer

    Public Property Fred As Integer

    Public Property Edtdoide As Integer

    Public Property Genecrispy As Integer

    Public Property Hysteriaptrance As Integer

    Public Property Officermodusponens As Integer

    Public Property Officermodustollens As Integer

    Public Property Sifidious As Integer

    Public Property Imhotepbizarros As Integer

    Public Property Barryukolmar As Integer


    '--
    '- Methods
    '--

    Public Overrides Function ToString() As String
        Return ""
    End Function

End Class

End Namespace



' Neighborhoods.vb -------------------------------------
Imports System

Namespace Quality_of_Life_Game.model 

' <summary>
' VB.Net - Model Class - Quality_of_Life_Game.Neighborhoods
' 2021-03-01 14:19:40
' </summary>
Public Class Neighborhoods 

    '--
    '- Constructor
    '- 
    '- Example: 
    '- Dim myNeighborhoods As New Neighborhoods 
    '--
    Public Sub New()
        '--
    End Sub

    '--
    '- Constructor
    '- 
    '- Example: 
    '- Dim myNeighborhoods As New Neighborhoods( val1, val2,.. )
    '--
    Public Sub New(ByVal _id As Integer, ByVal redneighborhood As Integer, ByVal yellowneighborhood As Integer, ByVal purpleneigborhood As Integer, ByVal greenneighborhood As Integer, ByVal orangeneighborhood As Integer, ByVal blueneighborhood As Integer)
        Me._id = _id
        Me.Redneighborhood = redneighborhood
        Me.Yellowneighborhood = yellowneighborhood
        Me.Purpleneigborhood = purpleneigborhood
        Me.Greenneighborhood = greenneighborhood
        Me.Orangeneighborhood = orangeneighborhood
        Me.Blueneighborhood = blueneighborhood
    End Sub


    '--
    '- Properties
    '--

    Public Property _id As Integer

    Public Property Redneighborhood As Integer

    Public Property Yellowneighborhood As Integer

    Public Property Purpleneigborhood As Integer

    Public Property Greenneighborhood As Integer

    Public Property Orangeneighborhood As Integer

    Public Property Blueneighborhood As Integer


    '--
    '- Methods
    '--

    Public Overrides Function ToString() As String
        Return ""
    End Function

End Class

End Namespace



' Social_Bubbles.vb -------------------------------------
Imports System

Namespace Quality_of_Life_Game.model 

' <summary>
' VB.Net - Model Class - Quality_of_Life_Game.Social_Bubbles
' 
' </summary>
Public Class Social_Bubbles 

    '--
    '- Constructor
    '- 
    '- Example: 
    '- Dim mySocial_Bubbles As New Social_Bubbles 
    '--
    Public Sub New()
        '--
    End Sub

    '--
    '- Constructor
    '- 
    '- Example: 
    '- Dim mySocial_Bubbles As New Social_Bubbles( val1, val2,.. )
    '--
    Public Sub New(ByVal _id As Integer, ByVal socioeconomicstatus As Integer, ByVal household As Integer, ByVal race As Integer, ByVal transportation As Integer, ByVal epidemiologicalfactors As Integer, ByVal healthfactors As Integer)
        Me._id = _id
        Me.Socioeconomicstatus = socioeconomicstatus
        Me.Household = household
        Me.Race = race
        Me.Transportation = transportation
        Me.Epidemiologicalfactors = epidemiologicalfactors
        Me.Healthfactors = healthfactors
    End Sub


    '--
    '- Properties
    '--

    Public Property _id As Integer

    Public Property Socioeconomicstatus As Integer

    Public Property Household As Integer

    Public Property Race As Integer

    Public Property Transportation As Integer

    Public Property Epidemiologicalfactors As Integer

    Public Property Healthfactors As Integer


    '--
    '- Methods
    '--

    Public Overrides Function ToString() As String
        Return ""
    End Function

End Class

End Namespace



' Health_Factors.vb -------------------------------------
Imports System

Namespace Quality_of_Life_Game.model 

' <summary>
' VB.Net - Model Class - Quality_of_Life_Game.Health_Factors
' 
' </summary>
Public Class Health_Factors 

    '--
    '- Constructor
    '- 
    '- Example: 
    '- Dim myHealth_Factors As New Health_Factors 
    '--
    Public Sub New()
        '--
    End Sub

    '--
    '- Constructor
    '- 
    '- Example: 
    '- Dim myHealth_Factors As New Health_Factors( val1, val2,.. )
    '--
    Public Sub New(ByVal _id As Integer, ByVal unexpectedpregnancy As Integer, ByVal measles As Integer, ByVal mumps As Integer, ByVal rubella As Integer, ByVal pneumonia As Integer, ByVal diabetes As Integer)
        Me._id = _id
        Me.Unexpectedpregnancy = unexpectedpregnancy
        Me.Measles = measles
        Me.Mumps = mumps
        Me.Rubella = rubella
        Me.Pneumonia = pneumonia
        Me.Diabetes = diabetes
    End Sub


    '--
    '- Properties
    '--

    Public Property _id As Integer

    Public Property Unexpectedpregnancy As Integer

    Public Property Measles As Integer

    Public Property Mumps As Integer

    Public Property Rubella As Integer

    Public Property Pneumonia As Integer

    Public Property Diabetes As Integer


    '--
    '- Methods
    '--

    Public Overrides Function ToString() As String
        Return ""
    End Function

End Class

End Namespace



' Socioeconomic_Status.vb -------------------------------------
Imports System

Namespace Quality_of_Life_Game.model 

' <summary>
' VB.Net - Model Class - Quality_of_Life_Game.Socioeconomic_Status
' 2021-03-01 14:36:28
' </summary>
Public Class Socioeconomic_Status 

    '--
    '- Constructor
    '- 
    '- Example: 
    '- Dim mySocioeconomic_Status As New Socioeconomic_Status 
    '--
    Public Sub New()
        '--
    End Sub

    '--
    '- Constructor
    '- 
    '- Example: 
    '- Dim mySocioeconomic_Status As New Socioeconomic_Status( val1, val2,.. )
    '--
    Public Sub New(ByVal _id As Integer, ByVal bankruptcy As Integer, ByVal unemployment As Integer, ByVal homeinvasion As Integer, ByVal incomedrop As Integer, ByVal incomeloss As Integer, ByVal eviction As Integer)
        Me._id = _id
        Me.Bankruptcy = bankruptcy
        Me.Unemployment = unemployment
        Me.Homeinvasion = homeinvasion
        Me.Incomedrop = incomedrop
        Me.Incomeloss = incomeloss
        Me.Eviction = eviction
    End Sub


    '--
    '- Properties
    '--

    Public Property _id As Integer

    Public Property Bankruptcy As Integer

    Public Property Unemployment As Integer

    Public Property Homeinvasion As Integer

    Public Property Incomedrop As Integer

    Public Property Incomeloss As Integer

    Public Property Eviction As Integer


    '--
    '- Methods
    '--

    Public Overrides Function ToString() As String
        Return ""
    End Function

End Class

End Namespace



' Random_Glucose_Levels.vb -------------------------------------
Imports System

Namespace Quality_of_Life_Game.model 

' <summary>
' VB.Net - Model Class - Quality_of_Life_Game.Random_Glucose_Levels
' 2021-03-02 08:29:01
' </summary>
Public Class Random_Glucose_Levels 

    '--
    '- Constructor
    '- 
    '- Example: 
    '- Dim myRandom_Glucose_Levels As New Random_Glucose_Levels 
    '--
    Public Sub New()
        '--
    End Sub

    '--
    '- Constructor
    '- 
    '- Example: 
    '- Dim myRandom_Glucose_Levels As New Random_Glucose_Levels( val1, val2,.. )
    '--
    Public Sub New(ByVal _id As Integer, ByVal kentuckyfriedchicken As Integer, ByVal ramenfury As Integer)
        Me._id = _id
        Me.Kentuckyfriedchicken = kentuckyfriedchicken
        Me.Ramenfury = ramenfury
    End Sub


    '--
    '- Properties
    '--

    Public Property _id As Integer

    Public Property Kentuckyfriedchicken As Integer

    Public Property Ramenfury As Integer


    '--
    '- Methods
    '--

    Public Overrides Function ToString() As String
        Return ""
    End Function

End Class

End Namespace