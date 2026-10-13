public class Solution {
    public bool IsValidSudoku(char[][] board) {
        Dictionary<int, HashSet<char>> rows = new Dictionary<int, HashSet<char>>();
        Dictionary<int, HashSet<char>> cols = new Dictionary<int, HashSet<char>>();
        Dictionary<string, HashSet<char>> squares = new Dictionary<string, HashSet<char>>();

        int max = 9;
        int min = 3;
        for (int i = 0; i < max; i++) {
            for (int j = 0; j < max; j++) {
                if (board[i][j] == '.')
                    continue;

                string squareKey = (i / min) + "," + (j / min);
                char key = board[i][j];
                if ((rows.ContainsKey(i) && rows[i].Contains(key)) ||
                    (cols.ContainsKey(j) && cols[j].Contains(key)) ||
                    (squares.ContainsKey(squareKey) && squares[squareKey].Contains(key))) {
                    return false;
                }

                if (!rows.ContainsKey(i)) {
                    rows[i] = new HashSet<char>();
                }
                if (!cols.ContainsKey(j)) {
                    cols[j] = new HashSet<char>();
                }
                if (!squares.ContainsKey(squareKey)) {
                    squares[squareKey] = new HashSet<char>();
                }

                rows[i].Add(board[i][j]);
                cols[j].Add(board[i][j]);
                squares[squareKey].Add(board[i][j]);
            }
        }
        return true;
    }
}
