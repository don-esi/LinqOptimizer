namespace LinqOptimizer.Core

    open System
    open System.Linq.Expressions

    type internal Session =

        /// Compiles a LambdaExpression into a Delegate.
        static member Compile (expr : LambdaExpression) : Delegate = 
            expr.Compile()