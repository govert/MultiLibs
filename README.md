# MultiLibs

Exports functions from multiple libraries, each with runtime dependencies.

From Lib1:
```
=SQLiteEvaluate("SELECT 1 + 1")
```

From Lib2:
```
=GetComputerName()
```

From AddIn:
```
=SayHello()
```
