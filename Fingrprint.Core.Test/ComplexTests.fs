namespace Fingrprint.Core.Test

open Fingrprint.Core
open NUnit.Framework

[<TestFixture>]
module ComplexTests =

    [<Test>]
    let ``Given two complex numbers, when added together then result is correct `` () =
        let a = Complex.make 5.0 3.0
        let b = Complex.make 1.0 15.0

        let c = a + b
        Assert.That (Complex.real c, Is.EqualTo(6.0))
        Assert.That (Complex.imaginary c, Is.EqualTo(18.0))

    [<Test>]
    let ``Given two complex numbers, when subtracted then result is correct`` () =
        let a = Complex.make 1.0 2.0
        let b = Complex.make 5.0 10.0
        let c = a - b

        Assert.That (Complex.real c, Is.EqualTo(-4.0))
        Assert.That (Complex.imaginary c, Is.EqualTo(-8.0))

    [<Test>]
    let ``Given a complex and a scalar, when multiplied together then result is correct`` () =
        let a = Complex.make 5.0 -15.0
        let b = a * 3.0

        Assert.That (Complex.real b, Is.EqualTo(15.0))
        Assert.That (Complex.imaginary b, Is.EqualTo(-45.0))

    [<Test>]
    let ``Given two complex numbers, when multiplied together then the result is correct`` () =
        let a = Complex.make 3.0 5.0
        let b = Complex.make 2.0 4.0
        let c = a * b

        Assert.That (Complex.real c, Is.EqualTo(34.0))
        Assert.That (Complex.imaginary c, Is.EqualTo(22.0))

    [<Test>]
    let ``Addition and subtraction are the identity function when the other value is unit`` () =
        let a = Complex.make 23.0 55.0
        let b = Complex.make 0.0 0.0
        let c = a + b
        let d = a - b

        Assert.That(a, Is.EqualTo(c))
        Assert.That(a, Is.EqualTo(d))

    [<Test>]
    let ``Multiplication is the identity function when the other value is unit`` () =
        let a = Complex.make 23.0 55.0
        let b = Complex.make 1.0 1.0
        let c = a * b

        Assert.That(a, Is.EqualTo(c))
