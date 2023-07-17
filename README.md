# net8-maui-autofac-repro
Trying to make a sample that shows this issue when using net8 (preview), autofac and MAUI.

The exception:
```
Autofac.Core.DependencyResolutionException
  Message=An exception was thrown while activating λ:Microsoft.Maui.IMauiHandlersFactory.
  Source=Autofac
  StackTrace:
   at Autofac.Core.Resolving.Middleware.ActivatorErrorHandlingMiddleware.Execute(ResolveRequestContext context, Action`1 next)
   at Autofac.Core.Resolving.Pipeline.ResolvePipelineBuilder.<>c__DisplayClass14_0.<BuildPipeline>b__1(ResolveRequestContext ctxt)
   at Autofac.Core.Pipeline.ResolvePipeline.Invoke(ResolveRequestContext ctxt)
   at Autofac.Core.Resolving.Middleware.RegistrationPipelineInvokeMiddleware.Execute(ResolveRequestContext context, Action`1 next)
   at Autofac.Core.Resolving.Pipeline.ResolvePipelineBuilder.<>c__DisplayClass14_0.b__1(ResolveRequestContext ctxt)
   at Autofac.Core.Resolving.Middleware.SharingMiddleware.<>c__DisplayClass5_0.b__0()
   at Autofac.Core.Lifetime.LifetimeScope.CreateSharedInstance(Guid id, Func`1 creator)
   at Autofac.Core.Lifetime.LifetimeScope.CreateSharedInstance(Guid primaryId, Nullable`1 qualifyingId, Func`1 creator)
   at Autofac.Core.Resolving.Middleware.SharingMiddleware.Execute(ResolveRequestContext context, Action`1 next)
   at Autofac.Core.Resolving.Pipeline.ResolvePipelineBuilder.<>c__DisplayClass14_0.b__1(ResolveRequestContext ctxt)
   at Autofac.Core.Resolving.Middleware.ScopeSelectionMiddleware.Execute(ResolveRequestContext context, Action`1 next)
   at Autofac.Core.Resolving.Pipeline.ResolvePipelineBuilder.<>c__DisplayClass14_0.<BuildPipeline>b__1(ResolveRequestContext ctxt)
   at Autofac.Core.Resolving.Middleware.CircularDependencyDetectorMiddleware.Execute(ResolveRequestContext context, Action`1 next)
   at Autofac.Core.Resolving.Pipeline.ResolvePipelineBuilder.<>c__DisplayClass14_0.b__1(ResolveRequestContext ctxt)
   at Autofac.Core.Pipeline.ResolvePipeline.Invoke(ResolveRequestContext ctxt)
   at Autofac.Core.Resolving.ResolveOperation.GetOrCreateInstance(ISharingLifetimeScope currentOperationScope, ResolveRequest request)
   at Autofac.Core.Resolving.ResolveOperation.ExecuteOperation(ResolveRequest request)
   at Autofac.Core.Resolving.ResolveOperation.Execute(ResolveRequest request)
   at Autofac.Core.Lifetime.LifetimeScope.ResolveComponent(ResolveRequest request)
   at Autofac.Core.Container.ResolveComponent(ResolveRequest request)
   at Autofac.ResolutionExtensions.TryResolveService(IComponentContext context, Service service, IEnumerable`1 parameters, Object& instance)
   at Autofac.ResolutionExtensions.ResolveOptionalService(IComponentContext context, Service service, IEnumerable`1 parameters)
   at Autofac.ResolutionExtensions.ResolveOptional(IComponentContext context, Type serviceType, IEnumerable`1 parameters)
   at Autofac.ResolutionExtensions.ResolveOptional(IComponentContext context, Type serviceType)
   at Autofac.Extensions.DependencyInjection.AutofacServiceProvider.GetService(Type serviceType)
   at Microsoft.Maui.MauiContext.WrappedServiceProvider.GetService(Type serviceType) in D:\a\_work\1\s\src\Core\src\MauiContext.cs:line 68
   at Microsoft.Maui.MauiContext.WrappedServiceProvider.GetService(Type serviceType) in D:\a\_work\1\s\src\Core\src\MauiContext.cs:line 68
   at Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService(IServiceProvider provider, Type serviceType)
   at Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService[IMauiHandlersFactory](IServiceProvider provider)
   at Microsoft.Maui.MauiContext.<.ctor>b__6_0() in D:\a\_work\1\s\src\Core\src\MauiContext.cs:line 27
   at System.Lazy`1[[Microsoft.Maui.IMauiHandlersFactory, Microsoft.Maui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]].ViaFactory(LazyThreadSafetyMode mode)
   at System.Lazy`1[[Microsoft.Maui.IMauiHandlersFactory, Microsoft.Maui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]].ExecutionAndPublication(LazyHelper executionAndPublication, Boolean useDefaultConstructor)
   at System.Lazy`1[[Microsoft.Maui.IMauiHandlersFactory, Microsoft.Maui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]].CreateValue()
   at System.Lazy`1[[Microsoft.Maui.IMauiHandlersFactory, Microsoft.Maui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]].get_Value()
   at Microsoft.Maui.MauiContext.get_Handlers() in D:\a\_work\1\s\src\Core\src\MauiContext.cs:line 35
   at Microsoft.Maui.Platform.ElementExtensions.SetHandler(Context nativeElement, IElement element, IMauiContext context) in D:\a\_work\1\s\src\Core\src\Platform\ElementExtensions.cs:line 149
   at Microsoft.Maui.Platform.ElementExtensions.SetApplicationHandler(Application platformApplication, IApplication application, IMauiContext context) in D:\a\_work\1\s\src\Core\src\Platform\ElementExtensions.cs:line 163
   at Microsoft.Maui.MauiApplication.OnCreate() in D:\a\_work\1\s\src\Core\src\Platform\Android\MauiApplication.cs:line 39
   at Android.App.Application.n_OnCreate(IntPtr jnienv, IntPtr native__this) in /Users/runner/work/1/s/xamarin-android/src/Mono.Android/obj/Release/net8.0/android-34/mcw/Android.App.Application.cs:line 1086
   at Android.Runtime.JNINativeWrapper.Wrap_JniMarshal_PP_V(_JniMarshal_PP_V callback, IntPtr jnienv, IntPtr klazz) in /Users/runner/work/1/s/xamarin-android/src/Mono.Android/Android.Runtime/JNINativeWrapper.g.cs:line 22
```
