module FsUnit

    open NUnit.Framework

    let beGreaterThan x = Is.GreaterThan(x)
    let beLessThan x = Is.LessThan(x)