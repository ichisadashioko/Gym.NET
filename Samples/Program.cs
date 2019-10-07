using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ebby.Gym.Envs.Classic;
using NumSharp;

namespace Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            var env = new CartPoleEnv();

            int numEpisodes = 10;

            for (int i = 0; i < numEpisodes; i++)
            {
                var state = env.Reset();
                var done = false;

                while (!done)
                {

                    // var action = agent.Process(state);
                    var action = env.ActionSpace.Sample();

                    var step = env.Step(action);
                    var nextState = step.Observation;
                    var reward = step.Reward;
                    var info = step.Information;

                    Console.WriteLine($"action: {action}, reward: {reward}, info: {info}, nextState: {nextState}");
                    done = step.Done;

                    state = nextState;
                    env.Render();
                }
            }
        }
    }
}
