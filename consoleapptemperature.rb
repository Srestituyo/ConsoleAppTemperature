# Documentation: https://docs.brew.sh/Formula-Cookbook
#                https://rubydoc.brew.sh/Formula
# PLEASE REMOVE ALL GENERATED COMMENTS BEFORE SUBMITTING YOUR PULL REQUEST!
class Consoleapptemperature < Formula
  desc ""
  homepage ""
  url "https://github.com/Srestituyo/ConsoleAppTemperature/archive/refs/tags/v1.0.0.tar.gz"
  sha256 "305ab30879eff8374c18b9af03d23c8fa9b35c071774cf03d6b83ebe8b9308f0"
  license ""

  # depends_on "cmake" => :build

  def install
    bin.install "katatemperatureconsoleapp"
  end

  test do
    # `test do` will create, run in and delete a temporary directory.
    #
    # This test will fail and we won't accept that! For Homebrew/homebrew-core
    # this will need to be a test that verifies the functionality of the
    # software. Run the test with `brew test ConsoleAppTemperature`. Options passed
    # to `brew install` such as `--HEAD` also need to be provided to `brew test`.
    #
    # The installed folder is not in the path, so use the entire path to any
    # executables being tested: `system "#{bin}/program", "do", "something"`.
    system "false"
  end
end
