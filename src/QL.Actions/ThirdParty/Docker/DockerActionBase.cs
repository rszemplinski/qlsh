using QL.Core.Actions;
using QL.Core.Attributes;

namespace QL.Actions.ThirdParty.Docker;

[Namespace("docker")]
[Deps(["docker"])]
public abstract class DockerActionBase<TArgs, TReturnType> : ActionBase<TArgs, TReturnType>
    where TArgs : class, new();

public abstract class DockerActionBase<TReturnType> : DockerActionBase<object, TReturnType>;
