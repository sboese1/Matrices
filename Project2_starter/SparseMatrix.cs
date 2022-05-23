using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2_starter
{
    public class SparseMatrix
    {
        private MatrixList[] _rows;
        private MatrixList[] _cols;
        int row;
        int col;

        public SparseMatrix(int rows, int cols)
        {
            _rows = new MatrixList[rows];
            _cols = new MatrixList[cols];
            row = rows;
            col = cols;
        }

        public void AddEntry(int val, int r, int c)
        {
            if (val == 0)
            {
                return;
            }
            else
            {
                Node n = new Node(val, r, c);

                if (_rows[r] != null)
                {
                    _rows[r].AddToList(n);
                }
                else
                {
                    _rows[r] = new MatrixList(true);
                    _rows[r].AddToList(n);
                }

                if (_cols[c] != null)
                {
                    _cols[c].AddToList(n);
                }
                else
                {
                    _cols[c] = new MatrixList(false);
                    _cols[c].AddToList(n);
                }
            }
        }

        //public SparseMatrix Times(SparseMatrix other)
        //{

        //}

        public SparseMatrix Plus(SparseMatrix other)
        {
            SparseMatrix result = new SparseMatrix(_rows.Length, _cols.Length);

            int count = 0;
            while (_rows[count] == null && count < _rows.Length-1)
            {
                count++;
            }
            int curRow1 = count;

            count = 0;
            while (other._rows[count] == null && count < other._rows.Length - 1)
            {
                count++;
            }
            int curRow2 = count;

            Node cur1 = _rows[curRow1].Head;
            Node cur2 = other._rows[curRow2].Head;

            while (cur1 != null || cur2 != null)
            {
                if (cur1 == null)
                {
                    result.AddEntry(cur2.Data, cur2.Row, cur2.Col);
                    cur2 = cur2.NextHoriz;
                }
                else if (cur2 == null)
                {
                    result.AddEntry(cur1.Data, cur1.Row, cur1.Col);
                    cur1 = cur1.NextHoriz;
                }
                else
                {
                    if (cur1.Row < cur2.Row)
                    {
                        result.AddEntry(cur1.Data, cur1.Row, cur1.Col);
                        cur1 = cur1.NextHoriz;
                    }
                    else if (cur1.Row > cur2.Row)
                    {
                        result.AddEntry(cur2.Data, cur2.Row, cur2.Col);
                        cur2 = cur2.NextHoriz;
                    }
                    else
                    {
                        if (cur1.Col < cur2.Col)
                        {
                            result.AddEntry(cur1.Data, cur1.Row, cur1.Col);
                            cur1 = cur1.NextHoriz;
                        }
                        else if (cur1.Col > cur2.Col)
                        {
                            result.AddEntry(cur2.Data, cur2.Row, cur2.Col);
                            cur2 = cur2.NextHoriz;
                        }
                        else
                        {
                            int temp = 0;
                            temp += cur1.Data;
                            temp += cur2.Data;
                            result.AddEntry(temp, cur1.Row, cur1.Col);
                            cur1 = cur1.NextHoriz;
                            cur2 = cur2.NextHoriz;
                        }
                    }
                }

                if (cur1 == null)
                {
                    int count1 = 0;
                    if (_rows.Length != 2)
                    {
                        Node temp = _rows[++curRow1].Head;
                        while (count1 < _rows.Length)
                        {
                            if (temp.NextHoriz != null || _cols.Length == 2)
                            {
                                cur1 = temp;
                                break;
                            }
                            temp = _rows[++curRow1].Head;
                        }
                    }
                }
                if (cur2 == null)
                {
                    int count1 = 0;
                    try
                    {
                        Node temp = other._rows[++curRow2].Head;
                        while (count1 < other._rows.Length || other._rows.Length == 2)
                        {
                            if (temp.NextHoriz != null)
                            {
                                cur2 = temp;
                                break;
                            }
                            temp = _rows[++curRow2].Head;
                        }
                    }
                    catch { }
                }
            }
            return result;
        }

        public class Node 
        {
            public int Data { get; private set; }
            public int Row { get; private set; }
            public int Col { get; private set; }
            public Node NextHoriz { get; set; }
            public Node NextVert { get; set; }

            public Node(int val, int row, int col)
            {
                Data = val;
                Row = row;
                Col = col;
                NextHoriz = null;
                NextVert = null;
            }
        }

        public class MatrixList
        {
            public Node Head { get; private set; }
            public Node Tail { get; private set; }
            private bool _isRow { get; set; }

            public MatrixList(bool isRow)
            {
                _isRow = isRow;
                Head = null;
                Tail = null;
            }

            public void AddToList(Node cur)
            {
                if (Head == null)
                {
                    Head = cur;
                }

                if (_isRow)
                {
                    if (Tail == null)
                    {
                        Tail = cur;
                    }
                    else
                    {
                        Tail.NextHoriz = cur;
                        Tail = cur;
                    }
                }
                else
                {
                    if (Tail == null)
                    {
                        Tail = cur;
                    }
                    else
                    {
                        Tail.NextVert = cur;
                        Tail = cur;
                    }
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            int count = 1;

            foreach (MatrixList m in _rows)
            {
                Node temp = m.Head;
                while (true)
                {
                    if (count % _rows.Length == 0)
                    {
                        sb.Append(temp.Data.ToString());
                        sb.Append(Environment.NewLine);
                    }
                    else
                    {
                        sb.Append(temp.Data.ToString() + " ");
                    }
                    temp = temp.NextHoriz;
                    count++;

                    if (temp == null)
                    {
                        break;
                    }
                }
            }
            return sb.ToString();
        }
    }
}
