import itertools
from datetime import datetime


def main():
    # Input formula
    formula = input("Input the formula: ").upper().replace(" ", "")
    start_time = datetime.now()
    # Split the formula to left and right sides by the "=" sign
    left_right = formula.split("=")
    check_error(len(left_right) == 2, "Error: formula must contain exactly one '=' sign")
    left = left_right[0]
    # Split the left side by '+' or '-' sign
    args = left.split("+")
    check_error(len(args) <= 2, "Error: formula contains more than one '+' sign")
    if len(args) == 1:
        args = left.split("-")
        check_error(len(args) <= 2, "Error: formula contains more than one '-' sign")
        check_error(len(args) == 2, "Error: formula contains neither '+' nor '-' sign")
        sign = "-"
    else:
        sign = "+"
    result = left_right[1]
    # Check the args and the result contain letters only
    check_error(args[0].isalpha() and args[1].isalpha() and result.isalpha(),
                "Error: arguments and result must contain letters only")
    # Collect all _different_ letters into a list
    all_letters = list({c for c in formula if c.isalpha()})
    n_letters = len(all_letters)
    check_error(n_letters <= 10, "Error: formula must contain less than or equal to 10 different letters")
    # Substitute letters with indices in the 'all_letters' array in all the arguments and in the result
    # Example: if the formula is "ac+bc=de" and the all_letters is ['C', 'A', 'E', 'B', 'D'],
    # then arg0n = [1, 0], arg1n = [3, 0], resultn = [4, 2]
    arg0n = substitute_with_indices(args[0], all_letters)
    arg1n = substitute_with_indices(args[1], all_letters)
    resultn = substitute_with_indices(result, all_letters)
    # 'n_letters'-length permutations of digits
    for perm in itertools.permutations(range(10), n_letters):
        # Exclude the case with leading zeros
        if perm[arg0n[0]] == 0 or perm[arg1n[0]] == 0 or perm[resultn[0]] == 0:
            continue
        # Check the formula
        arg0 = get_number(arg0n, perm)
        arg1 = get_number(arg1n, perm)
        res  = get_number(resultn, perm)
        if sign == "+":
            is_correct = arg0 + arg1 == res
        else:
            is_correct = arg0 - arg1 == res
        if is_correct:
            print(f"{arg0}{sign}{arg1}={res}")
    print(f"Elapsed time: {datetime.now() - start_time}")


def check_error(v, msg):
    if not v:
        raise RuntimeError(msg)


def substitute_with_indices(s, l):
    return [l.index(c) for c in s]


def get_number(arg, digits_perm):
    result = 0
    ten_power = 1
    for v in reversed(arg):
        result += digits_perm[v] * ten_power
        ten_power *= 10
    return result


if __name__ == "__main__":
    try:
        main()
    except Exception as e:
        print(e)