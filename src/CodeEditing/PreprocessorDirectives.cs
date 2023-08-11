namespace CodeEditing;

// CA: Reformat and Cleanup (add 'Reformat inactive preprocessor branches in file')
public class PreprocessorDirectives
{
#if RELEASE
public void M()
{
}
#else
public void M()
{
}
#endif
}
