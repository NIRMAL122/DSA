using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class KnightProbabilityinChessboardleetcodeproblem
    {
        public double KnightProbability(int N, int K, int r, int c)
        {
            // Possible moves for the knight
            int[][] moves = new int[8][]
            {
            new int[] {-2, -1}, new int[] {-1, -2}, new int[] {1, -2}, new int[] {2, -1},
            new int[] {2, 1}, new int[] {1, 2}, new int[] {-1, 2}, new int[] {-2, 1}
            };

            // 3D DP array to store the probabilities
            double[,,] dp = new double[K + 1, N, N];
            dp[0, r, c] = 1.0;

            for (int k = 1; k <= K; k++)
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        foreach (int[] move in moves)
                        {
                            int newRow = i + move[0];
                            int newCol = j + move[1];

                            if (IsValidMove(newRow, newCol, N))
                            {
                                dp[k, i, j] += dp[k - 1, newRow, newCol] / 8.0;
                            }
                        }
                    }
                }
            }

            double probability = 0.0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    probability += dp[K, i, j];
                }
            }

            return probability;
        }

        // Helper method to check if a move is valid
        private bool IsValidMove(int row, int col, int N)
        {
            return row >= 0 && row < N && col >= 0 && col < N;
        }
    }
}
