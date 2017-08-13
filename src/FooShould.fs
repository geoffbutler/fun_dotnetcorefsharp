namespace Tests

module FooShould =     
    open App
    open Xunit


    [<Fact>]
    let return_false() = 
        
        let expected = false

        let result = Foo.return_false

        Assert.StrictEqual(expected, result)


    [<Fact>]
    let return_true() = 
        
        let expected = true

        let result = Foo.return_true

        Assert.StrictEqual(expected, result)