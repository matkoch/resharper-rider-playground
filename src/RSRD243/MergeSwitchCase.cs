using System.Reflection;

namespace RSRD243;

internal class MergeSwitchCase
{
    public void M(MemberTypes memberType)
    {
        switch (memberType)
        {
            case MemberTypes.Field:
                N();
                break;
            case MemberTypes.Property:
                N();
                break;
            case MemberTypes.Method:
                O();
                break;
        }
    }

    private void N()
    {
    }

    private void O()
    {
    }
}
