namespace Types
{
    public enum Gematria
    {
        ALEPH = 1,
        BET = 2,
        GIMEL = 3,
        DALET = 4,
        HEH = 5,
        VAV = 6,
        ZAYIN = 7,
        CHET = 8,
        TET = 9,
        YOD = 10,
        CHAF = 20,
        LAMED = 30,
        MEM = 40,
        NUN = 50,
        SAMECH = 60,
        AYIN = 70,
        PEH = 80,
        TSADI = 90,
        QOF = 100,
        RESH = 200,
        SHIN = 300,
        TAV = 400
    }

    // Annotating the enum as flags allows ToString() to use the name.

    [System.Flags]
    public enum Breakfast
    {
        Oats        =          0b1,
        Sugar       =         0b10,
        Berries     =        0b100,
        Toast       =       0b1000,
        Eggs        =     0b1_0000,
        Almondmilk  =    0b10_0000,
        Kale        =   0b100_0000,
        Coffee      =  0b1000_0000
    }


}