
using StatePattern.Common;

Console.WriteLine("Package example of State Pattern\n");

var package = new Package();
package.PrintStatus();

package.Proceed();
package.PrintStatus();

package.Proceed();
package.PrintStatus();

package.Proceed();
package.PrintStatus();