//------------------------------------------------------------------------------
// <auto-generated>                                                             
//     This code was generated by a tool.                                       
//     Changes to this file may cause incorrect behavior and will be lost if    
//     the code is regenerated.                                                 
// </auto-generated>                                                            
//------------------------------------------------------------------------------
#pragma warning disable 436
#pragma warning disable 162
#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Develop_with_QSharp\",\"Name\":\"SampleQuantumRandomNumberGenerator\"},\"Attributes\":[],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:\\\\VSCode\\\\GitCreate\\\\Introduction-To-Azure-Quantum\\\\Develop_with_QSharp\\\\Qrng.qs\",\"Position\":{\"Item1\":7,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":45}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"Result\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Develop_with_QSharp\",\"Name\":\"SampleQuantumRandomNumberGenerator\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\VSCode\\\\GitCreate\\\\Introduction-To-Azure-Quantum\\\\Develop_with_QSharp\\\\Qrng.qs\",\"Position\":{\"Item1\":7,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":45}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Develop_with_QSharp\",\"Name\":\"SampleRandomNumberInRange\"},\"Attributes\":[],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:\\\\VSCode\\\\GitCreate\\\\Introduction-To-Azure-Quantum\\\\Develop_with_QSharp\\\\Qrng.qs\",\"Position\":{\"Item1\":13,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"max\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":40}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Int\"},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Develop_with_QSharp\",\"Name\":\"SampleRandomNumberInRange\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\VSCode\\\\GitCreate\\\\Introduction-To-Azure-Quantum\\\\Develop_with_QSharp\\\\Qrng.qs\",\"Position\":{\"Item1\":13,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Develop_with_QSharp\",\"Name\":\"SampleRandomNumber\"},\"Attributes\":[],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:\\\\VSCode\\\\GitCreate\\\\Introduction-To-Azure-Quantum\\\\Develop_with_QSharp\\\\Qrng.qs\",\"Position\":{\"Item1\":22,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Develop_with_QSharp\",\"Name\":\"SampleRandomNumber\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\VSCode\\\\GitCreate\\\\Introduction-To-Azure-Quantum\\\\Develop_with_QSharp\\\\Qrng.qs\",\"Position\":{\"Item1\":22,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"Documentation\":[]}")]
#line hidden
namespace Develop_with_QSharp
{
    [SourceLocation("C:\\VSCode\\GitCreate\\Introduction-To-Azure-Quantum\\Develop_with_QSharp\\Qrng.qs", OperationFunctor.Body, 8, 14)]
    public partial class SampleQuantumRandomNumberGenerator : Operation<QVoid, Result>, ICallable
    {
        public SampleQuantumRandomNumberGenerator(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "SampleQuantumRandomNumberGenerator";
        String ICallable.FullName => "Develop_with_QSharp.SampleQuantumRandomNumberGenerator";
        protected Allocate Allocate__
        {
            get;
            set;
        }

        protected Release Release__
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__H
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> Microsoft__Quantum__Measurement__MResetZ
        {
            get;
            set;
        }

        public override Func<QVoid, Result> __Body__ => (__in__) =>
        {
#line hidden
            {
#line 9 "C:\\VSCode\\GitCreate\\Introduction-To-Azure-Quantum\\Develop_with_QSharp\\Qrng.qs"
                var q = Allocate__.Apply();
#line hidden
                bool __arg1__ = true;
                try
                {
#line 10 "C:\\VSCode\\GitCreate\\Introduction-To-Azure-Quantum\\Develop_with_QSharp\\Qrng.qs"
                    Microsoft__Quantum__Intrinsic__H.Apply(q);
#line 11 "C:\\VSCode\\GitCreate\\Introduction-To-Azure-Quantum\\Develop_with_QSharp\\Qrng.qs"
                    return Microsoft__Quantum__Measurement__MResetZ.Apply(q);
                }
#line hidden
                catch
                {
                    __arg1__ = false;
                    throw;
                }
#line hidden
                finally
                {
                    if (__arg1__)
                    {
#line hidden
                        Release__.Apply(q);
                    }
                }
            }
        }

        ;
        public override void __Init__()
        {
            this.Allocate__ = this.__Factory__.Get<Allocate>(typeof(global::Microsoft.Quantum.Intrinsic.Allocate));
            this.Release__ = this.__Factory__.Get<Release>(typeof(global::Microsoft.Quantum.Intrinsic.Release));
            this.Microsoft__Quantum__Intrinsic__H = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.H));
            this.Microsoft__Quantum__Measurement__MResetZ = this.__Factory__.Get<ICallable<Qubit, Result>>(typeof(global::Microsoft.Quantum.Measurement.MResetZ));
        }

        public override IApplyData __DataIn__(QVoid data) => data;
        public override IApplyData __DataOut__(Result data) => new QTuple<Result>(data);
        public static System.Threading.Tasks.Task<Result> Run(IOperationFactory __m__)
        {
            return __m__.Run<SampleQuantumRandomNumberGenerator, QVoid, Result>(QVoid.Instance);
        }
    }

    [SourceLocation("C:\\VSCode\\GitCreate\\Introduction-To-Azure-Quantum\\Develop_with_QSharp\\Qrng.qs", OperationFunctor.Body, 14, 23)]
    public partial class SampleRandomNumberInRange : Operation<Int64, Int64>, ICallable
    {
        public SampleRandomNumberInRange(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "SampleRandomNumberInRange";
        String ICallable.FullName => "Develop_with_QSharp.SampleRandomNumberInRange";
        protected ICallable<Int64, Int64> Microsoft__Quantum__Math__BitSizeI
        {
            get;
            set;
        }

        protected ICallable<QVoid, Result> SampleQuantumRandomNumberGenerator__
        {
            get;
            set;
        }

        protected ICallable<IQArray<Result>, Int64> Microsoft__Quantum__Convert__ResultArrayAsInt
        {
            get;
            set;
        }

        protected ICallable<Int64, Int64> self
        {
            get;
            set;
        }

        public override Func<Int64, Int64> __Body__ => (__in__) =>
        {
            var max = __in__;
#line 15 "C:\\VSCode\\GitCreate\\Introduction-To-Azure-Quantum\\Develop_with_QSharp\\Qrng.qs"
            var bits = QArray<Result>.Create(0L);
#line 16 "C:\\VSCode\\GitCreate\\Introduction-To-Azure-Quantum\\Develop_with_QSharp\\Qrng.qs"
            foreach (var idxBit in new QRange(1L, Microsoft__Quantum__Math__BitSizeI.Apply(max)))
#line hidden
            {
#line 17 "C:\\VSCode\\GitCreate\\Introduction-To-Azure-Quantum\\Develop_with_QSharp\\Qrng.qs"
                bits = QArray<Result>.Add(bits, new QArray<Result>(SampleQuantumRandomNumberGenerator__.Apply(QVoid.Instance)));
            }

#line 19 "C:\\VSCode\\GitCreate\\Introduction-To-Azure-Quantum\\Develop_with_QSharp\\Qrng.qs"
            var sample = Microsoft__Quantum__Convert__ResultArrayAsInt.Apply(bits?.Copy());
#line 20 "C:\\VSCode\\GitCreate\\Introduction-To-Azure-Quantum\\Develop_with_QSharp\\Qrng.qs"
            return ((sample > max) ? self.Apply<Int64>(max) : sample);
        }

        ;
        public override void __Init__()
        {
            this.Microsoft__Quantum__Math__BitSizeI = this.__Factory__.Get<ICallable<Int64, Int64>>(typeof(global::Microsoft.Quantum.Math.BitSizeI));
            this.SampleQuantumRandomNumberGenerator__ = this.__Factory__.Get<ICallable<QVoid, Result>>(typeof(SampleQuantumRandomNumberGenerator));
            this.Microsoft__Quantum__Convert__ResultArrayAsInt = this.__Factory__.Get<ICallable<IQArray<Result>, Int64>>(typeof(global::Microsoft.Quantum.Convert.ResultArrayAsInt));
            this.self = this;
        }

        public override IApplyData __DataIn__(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __DataOut__(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 max)
        {
            return __m__.Run<SampleRandomNumberInRange, Int64, Int64>(max);
        }
    }

    [SourceLocation("C:\\VSCode\\GitCreate\\Introduction-To-Azure-Quantum\\Develop_with_QSharp\\Qrng.qs", OperationFunctor.Body, 23, -1)]
    public partial class SampleRandomNumber : Operation<QVoid, Int64>, ICallable
    {
        public SampleRandomNumber(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "SampleRandomNumber";
        String ICallable.FullName => "Develop_with_QSharp.SampleRandomNumber";
        protected ICallable<String, QVoid> Message__
        {
            get;
            set;
        }

        protected ICallable<Int64, Int64> SampleRandomNumberInRange__
        {
            get;
            set;
        }

        public override Func<QVoid, Int64> __Body__ => (__in__) =>
        {
#line 24 "C:\\VSCode\\GitCreate\\Introduction-To-Azure-Quantum\\Develop_with_QSharp\\Qrng.qs"
            var max = 50L;
#line 25 "C:\\VSCode\\GitCreate\\Introduction-To-Azure-Quantum\\Develop_with_QSharp\\Qrng.qs"
            Message__.Apply(String.Format("Sampling a random number between 0 and {0}: ", max));
#line 26 "C:\\VSCode\\GitCreate\\Introduction-To-Azure-Quantum\\Develop_with_QSharp\\Qrng.qs"
            return SampleRandomNumberInRange__.Apply(max);
        }

        ;
        public override void __Init__()
        {
            this.Message__ = this.__Factory__.Get<ICallable<String, QVoid>>(typeof(global::Microsoft.Quantum.Intrinsic.Message));
            this.SampleRandomNumberInRange__ = this.__Factory__.Get<ICallable<Int64, Int64>>(typeof(SampleRandomNumberInRange));
        }

        public override IApplyData __DataIn__(QVoid data) => data;
        public override IApplyData __DataOut__(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__)
        {
            return __m__.Run<SampleRandomNumber, QVoid, Int64>(QVoid.Instance);
        }
    }
}