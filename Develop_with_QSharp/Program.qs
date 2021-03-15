namespace Develop_with_QSharp {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
    
    @EntryPoint()
    operation SayHello() : Unit {
        Message("Hello quantum world!");
        let num = SampleQuantumRandomNumberGenerator();
        Message($"{num}");
    }
}
