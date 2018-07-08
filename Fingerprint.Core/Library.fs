namespace Fingerprint.Core

type Complex = private {
    Re : float
    Im : float
} with
    static member __.(+) (a : Complex, b : Complex) =
        {Re = a.Re + b.Re; Im = a.Im + b.Im}

    static member __.(-) (a : Complex, b : Complex) =
        {Re = a.Re - b.Re; Im = a.Im - b.Im}

    static member __.(*) (a : Complex, b : Complex) =
        {
            Re = a.Re * b.Re + a.Im * b.Im
            Im = a.Re * b.Im + a.Im * b.Re
        }

    static member __.(*) (a : Complex, b : float) =
        {Re = a.Re * b; Im = a.Im * b}

module Complex =

    let make (re : float) (im : float) =
        {Re = re; Im = im}

    let conjugate (a : Complex) =
        {Re = a.Re; Im = -a.Im}

    let real (a : Complex) = a.Re

    let imaginary (a : Complex) = a.Im
