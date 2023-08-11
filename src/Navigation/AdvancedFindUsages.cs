namespace Navigation;

public class AdvancedFindUsages
{
    // Navigation: Find Usages Advanced
    public void M(IController controller)
    {
        controller.Control();
        controller.Control();
        controller.Control(() => throw new Exception());

        dynamic c1 = controller;
        c1.Control();

        var c2 = controller as ControllerBase;
        c2.Control(() => 42);
    }

    public interface IController
    {
        void Control();
        void Control(Action act);
    }

    public abstract class ControllerBase : IController
    {
        public abstract void Control();
        public abstract void Control(Action act);

        public void Control<T>(Func<T> act)
        {
            act.Invoke();
        }
    }

    private class Controller : ControllerBase
    {
        public override void Control()
        {
        }

        public override void Control(Action act)
        {
        }
    }
}
