namespace ClassLibrary3

module MainModule =
    open System

    let thisFunction (x) = (1.0+x)*(1.0+x)/(x*x*x*Math.Sqrt(2.0+x))

    let funcVal (start, count, h, scaleFunc, f) = 
        seq {for i in 0..count-1 -> scaleFunc(start + (double)i*h, start + (double)(i+1)*h, f)} 

    let integrate(down, up, count, scaleFunc) =
        Seq.sum (funcVal(down, count, (up-down)/(double)count, scaleFunc, thisFunction))

open MainModule


module IntegrateRectangle=

    let rectangleScale (x1, x2, f) =
        f((x2+x1)/2.0)*(x2-x1)

    let integrate(down, up, count) =
        MainModule.integrate(down, up, count, rectangleScale)

module IntegrateSimpson =


    let segmentScale (x1, x2, f) =
        ((x2-x1)/6.0)*(f(x1)+4.0*f((x1+x2)/2.0)+f(x2))

    let simSequence (start, count, h, f) = 
        seq {for i in 1..count-1 do if i%2 = 0 then yield 2.0*f(start + (double)i*h) else yield 4.0*f(start + (double)i*h) } 

    
    let integrate(down, up, n) =
        let count = 2*n
        let h = (up-down)/(double)count
        (thisFunction(down) + thisFunction(up) + Seq.sum(simSequence(down, count, h, thisFunction)))*(h/3.0)
        